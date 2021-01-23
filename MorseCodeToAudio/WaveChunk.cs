namespace MorseCodeToAudio
{
    abstract class WaveChunk
    {
        public char[] ChunkId { get; set; }
        public uint ChunkSize { get; set; }

        public abstract byte[] ToBytes();
    }
}
