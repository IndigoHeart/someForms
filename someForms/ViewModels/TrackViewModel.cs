using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace someForms.ViewModels
{
    [POCOViewModel]
    public class TrackViewModel
    {
        private TrackInfo _track;


        //ze względu na POCO muszą być wirtualne żeby w czasie kompilacji coś tam z nimi zrobić
        public virtual int TrackId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Composer { get; set; }
        private void Load(TrackInfo track)
        {
            this._track = track;
            this.TrackId = _track.TrackId;
            this.Name = _track.Name;
            this.Composer = _track.Composer;
        }

        private void Store()
        {
            if (TrackId != _track.TrackId)
                _track.TrackId = TrackId;
            if (!string.Equals(Name, _track.Name))
                _track.Name = Name;
            if (!string.Equals(Composer, _track.Composer))
                _track.Composer = Composer;
        }

        protected TrackViewModel()
        {
            Load(new TrackList()[32]);
        }

        public static TrackViewModel Create()
        {
            return ViewModelSource.Create(() => new TrackViewModel());
        }
    }
}