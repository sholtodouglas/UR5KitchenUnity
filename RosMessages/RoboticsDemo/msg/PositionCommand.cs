//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.RoboticsDemo
{
    public class PositionCommand : Message
    {
        public const string RosMessageName = "robotics_demo/PositionCommand";

        public float pos_x;
        public float pos_y;
        public float pos_z;
        public float rot_r;
        public float rot_p;
        public float rot_y;
        public float gripper;

        public PositionCommand()
        {
            this.pos_x = 0.0f;
            this.pos_y = 0.0f;
            this.pos_z = 0.0f;
            this.rot_r = 0.0f;
            this.rot_p = 0.0f;
            this.rot_y = 0.0f;
            this.gripper = 0.0f;
        }

        public PositionCommand(float pos_x, float pos_y, float pos_z, float rot_r, float rot_p, float rot_y, float gripper)
        {
            this.pos_x = pos_x;
            this.pos_y = pos_y;
            this.pos_z = pos_z;
            this.rot_r = rot_r;
            this.rot_p = rot_p;
            this.rot_y = rot_y;
            this.gripper = gripper;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(BitConverter.GetBytes(this.pos_x));
            listOfSerializations.Add(BitConverter.GetBytes(this.pos_y));
            listOfSerializations.Add(BitConverter.GetBytes(this.pos_z));
            listOfSerializations.Add(BitConverter.GetBytes(this.rot_r));
            listOfSerializations.Add(BitConverter.GetBytes(this.rot_p));
            listOfSerializations.Add(BitConverter.GetBytes(this.rot_y));
            listOfSerializations.Add(BitConverter.GetBytes(this.gripper));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            this.pos_x = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.pos_y = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.pos_z = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.rot_r = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.rot_p = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.rot_y = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.gripper = BitConverter.ToSingle(data, offset);
            offset += 4;

            return offset;
        }

        public override string ToString()
        {
            return "PositionCommand: " +
            "\npos_x: " + pos_x.ToString() +
            "\npos_y: " + pos_y.ToString() +
            "\npos_z: " + pos_z.ToString() +
            "\nrot_r: " + rot_r.ToString() +
            "\nrot_p: " + rot_p.ToString() +
            "\nrot_y: " + rot_y.ToString() +
            "\ngripper: " + gripper.ToString();
        }
    }
}
