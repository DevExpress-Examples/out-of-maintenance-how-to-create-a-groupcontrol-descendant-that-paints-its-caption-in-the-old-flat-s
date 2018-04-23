using DevExpress.Skins;
using DevExpress.Utils.Drawing;

namespace DxSample.Editors {
    public class SimpleGroupBorderPainter :SkinGroupBorderPainter {
        public SimpleGroupBorderPainter(SkinGroupObjectPainter groupPainter, ISkinProvider provider) : base(groupPainter, provider) { }

        protected override SkinElement GetPanelSkinElement(GroupObjectInfoArgs info) {
            return CommonSkins.GetSkin(this.Provider)[CommonSkins.SkinGroupPanel];
        }
    }
}
