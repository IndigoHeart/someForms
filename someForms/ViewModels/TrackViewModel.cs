using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;

namespace someForms.ViewModels
{
    [POCOViewModel]
    public class TrackViewModel
    {
        private TrackInfo _track;
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
    }
}