using System;
using System.Collections.Generic;
using System.Net;
using Modbus.Message;

namespace PTZRv2 {
  public class CustomMessageResponse : IModbusMessage {
    private byte _functionCode;
    private byte _slaveAddress;
    private ushort _startAddress;
    private ushort _numberOfPoints;
    private ushort _transactionId;

    public byte[] MessageFrame {
      get {
        List<byte> frame = new List<byte>();
        frame.Add(SlaveAddress);
        frame.AddRange(ProtocolDataUnit);

        return frame.ToArray();
      }
    }

    public byte[] ProtocolDataUnit {
      get {
        List<byte> pdu = new List<byte>();

        pdu.Add(0x26);
        pdu.Add(0x00);


        return pdu.ToArray();
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

    public ushort StartAddress {
      get {
        return _startAddress;
      }
      set {
        _startAddress = value;
      }
    }

    public ushort NumberOfPoints {
      get {
        return _numberOfPoints;
      }
      set {
        _numberOfPoints = value;
      }
    }

    public void Initialize(byte[] frame) {
      if (frame == null)
        throw new ArgumentNullException("frame");

      if (frame.Length < 2)
        throw new FormatException("Message frame does not contain enough bytes.");

      SlaveAddress = frame[0];
      FunctionCode = frame[1];
      StartAddress = (ushort)0x01;
      NumberOfPoints = (ushort)2;
    }
  }
}
