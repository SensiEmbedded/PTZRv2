using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modbus.Data;
using Modbus.Message;
using Unme.Common;
using System.Net;

namespace PTZRv2 {
  public class CCustomMessageRequest : IModbusMessage {
    private byte _functionCode;
		private byte _slaveAddress;
		private byte _byteCount;
		//private ushort _startAddress;
		private ushort _numberOfPoints;
		private ushort _transactionId;
		private RegisterCollection _data;

    
    public CCustomMessageRequest(byte functionCode, byte slaveAddress, RegisterCollection data) {
      _functionCode = functionCode;
      _slaveAddress = slaveAddress;
      _numberOfPoints = (ushort)data.Count;
      _byteCount = data.ByteCount;
      _data = data;
    }
    public byte[] MessageFrame {
      get {
        List<byte> frame = new List<byte>();
        frame.Add(SlaveAddress);
        frame.AddRange(ProtocolDataUnit);

        return frame.ToArray();
      }
    }
    public ushort TransactionId {
      get {
        return _transactionId;
      }
      set {
        _transactionId = value;
      }
    }
    public byte[] ProtocolDataUnit {
      get {
        List<byte> pdu = new List<byte>();

        //pdu.Add(0x26);
        //pdu.Add(0x00);

        pdu.Add(FunctionCode);
        pdu.AddRange(_data.NetworkBytes);
        //pdu.AddRange(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)StartAddress)));
        //pdu.AddRange(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)NumberOfPoints)));

        /*pdu.AddRange(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)StartAddress)));
        pdu.AddRange(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)NumberOfPoints)));
        pdu.Add(ByteCount);
        pdu.AddRange(Data.NetworkBytes);
        */
        return pdu.ToArray();
      }
    }
    public byte FunctionCode {
      get {
        return _functionCode;
      }
      set {
        _functionCode = value;
      }
    }

    public byte SlaveAddress {
      get {
        return _slaveAddress;
      }
      set {
        _slaveAddress = value;
      }
    }
    /*
    public ushort StartAddress {
      get {
        return _startAddress;
      }
      set {
        _startAddress = value;
      }
    } */

    public ushort NumberOfPoints {
      get {
        return _numberOfPoints;
      }
      set {
        _numberOfPoints = value;
      }
    }

    public byte ByteCount {
      get {
        return _byteCount;
      }
      set {
        _byteCount = value;
      }
    }

    public RegisterCollection Data {
      get {
        return _data;
      }
      set {
        _data = value;
      }
    }

    public void Initialize(byte[] frame) {
      if (frame == null)
        throw new ArgumentNullException("frame");

      if (frame.Length < 7 || frame.Length < 7 + frame[6])
        throw new FormatException("Message frame does not contain enough bytes.");

      SlaveAddress = frame[0];
      FunctionCode = frame[1];
      //./StartAddress = (ushort)0x01;
      NumberOfPoints = (ushort)2;
      ByteCount = frame[6];
      Data = new RegisterCollection(frame.Slice(7, ByteCount).ToArray());
    }
  }
}
