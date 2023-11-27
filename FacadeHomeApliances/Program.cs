
using FacadeHomeApliances;
using FacadeHomeApliances.Subsystems;

DVDPlayer dvd = new DVDPlayer();
Projector projector = new Projector();
Speakers speakers = new Speakers();

HomeTheaterFacade intelligentHome = new HomeTheaterFacade(dvd,projector,speakers);

intelligentHome.PrepareToMovie();
intelligentHome.WatchMovie("Titanic");
intelligentHome.MovieWatched();