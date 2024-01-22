using System;

namespace DevelopCApp_Homework_02
{
	public class Bits: IBits
	{
        public long Value { get; private set; } = 0;
        public byte SizeOfValue { get; private set; } = 1;

		public Bits(long b)
		{
            this.Value = b;
            SizeOfValue = sizeof(long) * 8;
		}

        public Bits(int b)
        {
            this.Value = b;
            SizeOfValue = sizeof(int) * 8;
        }

        public Bits(byte b)
        {
            this.Value = b;
            SizeOfValue = sizeof(byte) * 8;
        }

        public bool GetBit(int i)
        {
            if (i > SizeOfValue || i < 0) return false;

            return ((Value >> i) & 1) == 1;
        }

        public void SetBit(int i, bool val)
        {
            if (i > SizeOfValue || i < 0) return;
            if (val == true)
                Value = (byte)(Value | (1 << i));
            else
            {
                var mask = (byte)(1 << i);
                mask = (byte)(0xff ^ mask);
                Value &= (byte)(Value & mask);
            }
        }

        public static implicit operator byte(Bits b) => (byte)b.Value;
        public static explicit operator Bits(byte b) => new Bits(b);

        public static implicit operator long(Bits b) => (long)b.Value;
        public static explicit operator Bits(long b) => new Bits(b);

        public static implicit operator int(Bits b) => (int)b.Value;
        public static explicit operator Bits(int b) => new Bits(b);

    }
}

