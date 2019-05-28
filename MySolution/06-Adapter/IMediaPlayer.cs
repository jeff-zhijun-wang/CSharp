using System;

namespace _06_Adapter
{
    public interface IMediaPlayer
    {
        void play(string audioType, string filename);
    }

    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {

            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer = new VLCPlayer();

            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer = new MP4Player();
            }
        }


        public void play(string audioType, string filename)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer.playVLC(filename);

            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer.playMP4(filename);
            }
        }
    }

public class AudioPlayer: IMediaPlayer
    {
        MediaAdapter mediaAdapter;
        public void play(string audioType, string fileName)
    {
            mediaAdapter = new MediaAdapter(audioType);
            mediaAdapter.play(audioType, fileName);
    }
}

}
