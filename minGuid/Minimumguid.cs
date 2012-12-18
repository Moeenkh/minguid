using System;

namespace minGuid
{
    class Minimumguid
    {
        public string MinGuid()
        {
            long i = 1;
            for (int index = 0; index < Guid.NewGuid().ToByteArray().Length; index++)
            {
                byte b = Guid.NewGuid().ToByteArray()[index];
                i *= (b + 1);
            }

            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
    }
}
