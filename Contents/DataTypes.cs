namespace StudiesCSharp.Contents
{
    public class DataTypes
    {
        public static void ReturnDataTypes()
        {
            #region Interer Numbers
                // signed types
                byte b = 2; // (8 bit) - 0 to 255
                short s = 32767; // (16 bit) - -32768 to 32767
                int a = 2147483647; // (32 bit) - -2147483648 to 2147483647
                long l = -9223372036854775808; // (64 bit) - -9223372036854775808 to 9223372036854775807
                
                // unsigned types
                sbyte ub = sbyte.MaxValue; // -128 to 127
                ushort us; // (16 bit) - 0 to 65.535
                uint ua; // (32 bit) - 0 to 4.294.967.295
                ulong ul; // (64 bit) - 0 to 18.446.744.073.709.551.615
            #endregion

            #region Real Numbers
                float f = 10.4f; // (32 bit)
                double d = 123.54; // (64 bit)
                decimal de = 3.45345739753245m; // (128 bit)
            #endregion

            #region Boolean Type
                bool bo = true; // (8-bit)
                bool isTrueOrFalse = 12 > 32;
            #endregion
            
            #region Characters Types
                char firstCharOfMyName = 'Y'; // (16-bit)
                string str = "Hello, my name is Yuri";
                string name = "Yuri";
                string phrase = "My name is" + "Yuri";
                string uncompletedPhrase = "My name is" + name;
                string completedPhrase = $"{uncompletedPhrase} + {name}";
            #endregion

            #region Var Type
                var age = 21; // number type
                var myName = "Yuri"; // string type

                // age = "Yuri" // ERROR
                age = 22; // should be same type
            #endregion

            #region Object Type
                object age2 = 21; // it will be object type
                object name2 = "Ricardo"; // it will be object type

                age2 = "21"; // there is no have error here
            #endregion
            
            #region Null Type
                int? num = null;
            #endregion
        }
    }
}