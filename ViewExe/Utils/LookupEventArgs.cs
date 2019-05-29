using System;

namespace MVCHIS.Common {
    class LookupEventArgs : EventArgs {
        public string SelectedValueFromLookup { get; private set; }
        public LookupEventArgs(string selected) {
            SelectedValueFromLookup = $"{selected}".Trim();
        }
    }
}
