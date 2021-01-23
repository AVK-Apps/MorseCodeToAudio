using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MorseCodeToAudio
{
    class DataChunk : WaveChunk
    {
        public short[] ChunkData { get; set; }

        public DataChunk(short[] data)
        {
            ChunkId = "data".ToCharArray();
            ChunkSize = (uint)(data.Length * 2);
            ChunkData = data;
        }

        public override byte[] ToBytes()
        {
            List<byte> bytes = new List<byte>();

            bytes.AddRange(Encoding.UTF8.GetBytes(ChunkId));
            bytes.AddRange(BitConverter.GetBytes(ChunkSize));

            foreach (short datum in ChunkData)
                bytes.AddRange(BitConverter.GetBytes(datum));

            return bytes.ToArray<byte>();
        }
    }
}
