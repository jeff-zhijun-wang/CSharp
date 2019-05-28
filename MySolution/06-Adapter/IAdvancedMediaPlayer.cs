using System;

namespace _06_Adapter
{
    public interface IAdvancedMediaPlayer
    {
        void playVLC(string filename);
        void playMP4(string filename);
    }

    public class VLCPlayer : IAdvancedMediaPlayer
    {
        public void playVLC(string filename)
        {
            Console.WriteLine("Playing vlc file!");
        }

        public void playMP4(string filename)
        {
            throw new System.NotImplementedException();
        }

    }

    public class MP4Player : IAdvancedMediaPlayer
    {
        public void playMP4(string filename)
        {
            Console.WriteLine("Playing MP4 file!");
        }

        public void playVLC(string filename)
        {
            throw new System.NotImplementedException();
        }
    }
}
