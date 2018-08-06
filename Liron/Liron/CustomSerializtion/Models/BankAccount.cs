using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CustomSerializtion.Models
{
    [Serializable]
    public class BankAccount : ISerializable
    {
        public int Id { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLasttName { get; set; }
        public string Password { get; set; }
        public string BankAddress { get; set; }
        

        public BankAccount()
        {

        }
        
        //Serialize
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Id), $"0000{Id}");
            info.AddValue("FullName", $"{OwnerFirstName}-{OwnerLasttName}");
            info.AddValue(nameof(BankAddress), BankAddress);
        }

        //Deserialize
        public BankAccount(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32(nameof(Id));

            var fullName = info.GetString("FullName").Split('-');
            OwnerFirstName = fullName[0];
            OwnerLasttName = fullName[1];

            BankAddress = info.GetString(nameof(BankAddress));
        }

        [OnSerializing]
        protected void OnSerializing(StreamingContext context)
        {
           Debug.WriteLine("Start Serializing!!");
        }

        [OnSerialized]
        protected void OnSerialized(StreamingContext context)
        {
            Debug.WriteLine("Serializing Ended!!");
        }

        [OnDeserialized]
        protected void OnDeserialized(StreamingContext context)
        {
            Debug.WriteLine("Start DeSerializing!!");
        }

        [OnDeserializing]
        protected void OnDeserializing(StreamingContext context)
        {
            Debug.WriteLine("DeSerializing Ended!!");
        }
    }
}
