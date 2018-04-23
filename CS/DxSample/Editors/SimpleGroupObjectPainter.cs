using System.Drawing;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace DxSample.Editors {
    public class SimpleGroupObjectPainter :SkinGroupObjectPainter {
        public SimpleGroupObjectPainter(IPanelControlOwner owner, ISkinProvider provider) : base(owner, provider) { }
        public SimpleGroupObjectPainter(IPanelControlOwner owner, ISkinProvider provider, string groupPanelSkinElementName) : base(owner, provider, groupPanelSkinElementName) { }

        protected override Rectangle GetBorderBounds(GroupObjectInfoArgs info) {
            Rectangle result = info.Bounds;
            if (info.CaptionBounds.IsEmpty) return result;
            if (this.IsVerticalCaption(info)) {
                int width = info.CaptionBounds.Width / 2;
                if (this.GetCaptionLocation(info) == Locations.Left) result.X += width;
                result.Width -= width;
            } else {
                int height = info.CaptionBounds.Height / 2;
                if (this.GetCaptionLocation(info) == Locations.Top) result.Y += height;
                result.Height -= height;
            }
            return result;
        }

        protected override void DrawCaptionSkinElement(GroupObjectInfoArgs info) { }

        protected override ObjectPainter GetBorderPainter(ObjectInfoArgs e) {
            GroupObjectInfoArgs args = (GroupObjectInfoArgs)e;
            if (args.BorderStyle == BorderStyles.NoBorder && !args.ShowCaption)
                return new SkinGroupEmptyBorderPainter(this.Provider);
            return new SimpleGroupBorderPainter(this, this.Provider);
        }

        protected override void DrawCaptionText(GroupObjectInfoArgs info) {
            base.DrawCaptionText(info);
        }

        protected override Color GetActualCaptionTextBackColor(GroupObjectInfoArgs info) {
            Color result = base.GetActualCaptionTextBackColor(info);
            return result.IsEmpty ? info.Appearance.BackColor : result;
        }
    }
}
