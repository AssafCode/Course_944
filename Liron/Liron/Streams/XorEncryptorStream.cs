using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Streams
{
    class XorEncryptorStream : DecoratorStream
    {
        private readonly byte _key;
        public XorEncryptorStream(Stream stream, byte key) : base(stream)
        {
            _key = key;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            for (int i = offset; i < offset + count; i++)
                buffer[i] ^= _key;

            base.Write(buffer, offset, count);
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            var readCount = base.Read(buffer, offset, count);
            for (int i = offset; i < offset + count; i++)
                buffer[i] ^= _key;

            return readCount;
        }
    }
}
