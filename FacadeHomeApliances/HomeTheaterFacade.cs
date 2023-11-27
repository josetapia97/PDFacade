using FacadeHomeApliances.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeHomeApliances
{
    public class HomeTheaterFacade
    {
        private DVDPlayer _dvdPlayer;
        private Projector _projector;
        private Speakers _speakers;

        public HomeTheaterFacade(DVDPlayer dvdPlayer, Projector projector, Speakers speakers)
        {
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _speakers = speakers;
        }

        public void PrepareToMovie()
        {
            _dvdPlayer.On();
            _projector.On();
            _speakers.On();
        }

        public void WatchMovie(string movie)
        {
            _speakers.ChangeVolume(90);
            _projector.AdjustResolution();
            _dvdPlayer.PlayMovie(movie);
        }

        public void MovieWatched()
        {
            _dvdPlayer.Off();
            _projector.Off();
            _speakers.Off();
        }
    }
}
    
