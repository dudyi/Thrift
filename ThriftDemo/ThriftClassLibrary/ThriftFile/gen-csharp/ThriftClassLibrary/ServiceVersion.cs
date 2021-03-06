/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThriftClassLibrary
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ServiceVersion : TBase
  {

    public string Name { get; set; }

    public string Version { get; set; }

    public ServiceVersion() {
    }

    public ServiceVersion(string name, string version) : this() {
      this.Name = name;
      this.Version = version;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_name = false;
        bool isset_version = false;
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
                isset_name = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Version = iprot.ReadString();
                isset_version = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
        if (!isset_name)
          throw new TProtocolException(TProtocolException.INVALID_DATA, "required field Name not set");
        if (!isset_version)
          throw new TProtocolException(TProtocolException.INVALID_DATA, "required field Version not set");
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("ServiceVersion");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Name == null)
          throw new TProtocolException(TProtocolException.INVALID_DATA, "required field Name not set");
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
        if (Version == null)
          throw new TProtocolException(TProtocolException.INVALID_DATA, "required field Version not set");
        field.Name = "version";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Version);
        oprot.WriteFieldEnd();
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("ServiceVersion(");
      __sb.Append(", Name: ");
      __sb.Append(Name);
      __sb.Append(", Version: ");
      __sb.Append(Version);
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
