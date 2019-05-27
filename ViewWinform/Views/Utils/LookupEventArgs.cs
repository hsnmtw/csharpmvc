using System;

namespace MVCWinform.Common {
    class LookupEventArgs : EventArgs {
        public string SelectedValueFromLookup { get; set; }
        public string SelectedDescriptionFromLookup { get; set; }
        public LookupEventArgs(string svfl, string sdfl) {
            this.SelectedValueFromLookup = $"{svfl}".Trim();
            this.SelectedDescriptionFromLookup = $"{sdfl}".Trim();
        }
    }
}
