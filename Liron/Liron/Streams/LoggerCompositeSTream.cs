using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Streams
{
    class LoggerCompositeSTream : Stream
    {
        public LoggerCompositeSTream(params Stream[] stream)
        {
            _streams = stream;
        }

        private readonly Stream[] _streams;

        public override bool CanRead => false;

        public override bool CanSeek => false;

        public override bool CanWrite => true;

        public override long Length
        {
            get
            {
                return (from s in _streams select s.Length).Max();
            }
        }

        public override long Position { get => _streams.First().Position; set => Array.ForEach(_streams, s => s.Position = value);  }

        public override void Flush()
        {
            Array.ForEach(_streams, s => s.Flush());
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            Array.ForEach(_streams, s => s.SetLength(value));
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            Array.ForEach(_streams, s => s.Write(buffer, offset, count));
        }

        public override void Close()
        {
            Array.ForEach(_streams, s => s.Close());
            base.Close();
        }
    }
}
