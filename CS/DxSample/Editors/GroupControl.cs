using DevExpress.LookAndFeel;
using DevExpress.Utils.Drawing;

namespace DxSample.Editors {
    public class GroupControl : DevExpress.XtraEditors.GroupControl {
        protected override ObjectPainter CreatePainter() {
            if (this.LookAndFeel != null && this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                return new SimpleGroupObjectPainter(this, this.LookAndFeel.ActiveLookAndFeel);
            return base.CreatePainter();
        }
    }
}
