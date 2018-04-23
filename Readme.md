# How to create a GroupControl descendant that paints its caption in the old flat style


Our <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsGroupControltopic">GroupControl</a> container control paints a caption as a stylish colored box. Its caption blends well with other skinnable DevExpress controls, but sometimes our customers just want to display a simple frame around controls with text as a caption (something like the standard <strong>GroupBox</strong> control, but with the <strong>GroupControl</strong> features, such as a caption image). The picture below demonstrates the difference between the standard GroupBox and the GroupControl.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-groupcontrol-descendant-that-paints-its-caption-in-the-old-flat-style-t347862/15.1.3+/media/b902685b-d732-11e5-80bf-00155d62480c.png"><br>This example demonstrates how to create a custom control inherited from the GroupControl class and implement a custom painter that draws the header in a different style. This approach has known limitations:<br>1. The <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsGroupControl_AllowBorderColorBlendingtopic">Border Color Blending</a> feature is not supported.<br>2. It has minor compatibility issues with a few old skins. In any case, the painting mode implemented in this example is good with all the modern skins and most of the rest skins.

<br/>


