﻿using MVCHIS.Common;
using System;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.Audit)]
    public partial class AuditForm: AuditView {
        
        public virtual void UpdateModel() { var _ = Model; }

        public AuditForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void AuditView_Load(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }
    }
    
}
