using System;
using System.Text;

namespace _18.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            long longTest;

            StringBuilder builder = new StringBuilder();

            if (!long.TryParse(num, out longTest))
            {
                Console.WriteLine("{0} can't fit in any type", num);
            }
            else
            {
                sbyte sbyteTest;
                if (sbyte.TryParse(num, out sbyteTest))
                    builder.Append("* sbyte").AppendLine();

                byte byteTest;
                if (byte.TryParse(num, out byteTest))
                    builder.Append("* byte").AppendLine();

                short shortTest;
                if (short.TryParse(num, out shortTest))
                    builder.Append("* short").AppendLine();

                ushort ushortTest;
                if (ushort.TryParse(num, out ushortTest))
                    builder.Append("* ushort").AppendLine();

                int intTest;
                if (int.TryParse(num, out intTest))
                    builder.Append("* int").AppendLine();

                uint uintTest;
                if (uint.TryParse(num, out uintTest))
                    builder.Append("* uint").AppendLine();

                if (long.TryParse(num, out longTest))
                    builder.Append("* long").AppendLine();

                Console.WriteLine("{0} can fit in:\n{1}", num, builder.ToString());
            }
        }
    }
}