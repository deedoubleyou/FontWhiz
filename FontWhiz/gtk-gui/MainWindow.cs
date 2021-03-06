
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox1;
	private global::Gtk.VBox vbox1;
	private global::Gtk.Frame frame4;
	private global::Gtk.Alignment GtkAlignment3;
	private global::Gtk.VBox vbox3;
	private global::Gtk.RadioButton installedfontsradiobutton;
	private global::Gtk.RadioButton fromfileradiobutton;
	private global::Gtk.Label GtkLabel2;
	private global::Gtk.Frame installedfontsframe;
	private global::Gtk.Alignment GtkAlignment1;
	private global::Gtk.ComboBox installedfontscombobox;
	private global::Gtk.Label GtkLabel3;
	private global::Gtk.Frame fromfileframe;
	private global::Gtk.Alignment GtkAlignment2;
	private global::Gtk.FileChooserButton fontfilechooserbutton;
	private global::Gtk.Label GtkLabel5;
	private global::Gtk.Frame frame1;
	private global::Gtk.Alignment GtkAlignment;
	private global::Gtk.VBox vbox4;
	private global::Gtk.HBox hbox7;
	private global::Gtk.Label sizelabel1;
	private global::Gtk.SpinButton sizespinbutton;
	private global::Gtk.CheckButton antialiasingcheckbutton;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Label label4;
	private global::Gtk.ColorButton fontcolorbutton;
	private global::Gtk.Label label5;
	private global::Gtk.HBox hbox6;
	private global::Gtk.CheckButton transparentbackgroundcheckbutton;
	private global::Gtk.ColorButton backgroundcolorbutton;
	private global::Gtk.Label GtkLabel11;
	private global::Gtk.VBox vbox2;
	private global::Gtk.Frame outputframe;
	private global::Gtk.Alignment GtkAlignment8;
	private global::Gtk.VBox vbox6;
	private global::Gtk.Button previewbutton;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Image previewimage;
	private global::Gtk.Frame frame2;
	private global::Gtk.Alignment GtkAlignment9;
	private global::Gtk.VBox vbox5;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Label label1;
	private global::Gtk.Label labelWidth;
	private global::Gtk.HBox hbox5;
	private global::Gtk.Label label2;
	private global::Gtk.Label labelHeight;
	private global::Gtk.HBox hbox8;
	private global::Gtk.Label label3;
	private global::Gtk.Label labelCellSize;
	private global::Gtk.Label GtkLabel10;
	private global::Gtk.Button generatebutton;
	private global::Gtk.Label GtkLabel14;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Font Whiz");
		this.Icon = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./icon.png"));
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.WidthRequest = 200;
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame4 = new global::Gtk.Frame ();
		this.frame4.Name = "frame4";
		this.frame4.ShadowType = ((global::Gtk.ShadowType)(2));
		// Container child frame4.Gtk.Container+ContainerChild
		this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment3.Name = "GtkAlignment3";
		this.GtkAlignment3.LeftPadding = ((uint)(12));
		this.GtkAlignment3.TopPadding = ((uint)(2));
		this.GtkAlignment3.RightPadding = ((uint)(12));
		this.GtkAlignment3.BottomPadding = ((uint)(2));
		// Container child GtkAlignment3.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.installedfontsradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Installed Fonts"));
		this.installedfontsradiobutton.CanFocus = true;
		this.installedfontsradiobutton.Name = "installedfontsradiobutton";
		this.installedfontsradiobutton.DrawIndicator = true;
		this.installedfontsradiobutton.UseUnderline = true;
		this.installedfontsradiobutton.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.vbox3.Add (this.installedfontsradiobutton);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.installedfontsradiobutton]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.fromfileradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("From File"));
		this.fromfileradiobutton.CanFocus = true;
		this.fromfileradiobutton.Name = "fromfileradiobutton";
		this.fromfileradiobutton.DrawIndicator = true;
		this.fromfileradiobutton.UseUnderline = true;
		this.fromfileradiobutton.Group = this.installedfontsradiobutton.Group;
		this.vbox3.Add (this.fromfileradiobutton);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.fromfileradiobutton]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.GtkAlignment3.Add (this.vbox3);
		this.frame4.Add (this.GtkAlignment3);
		this.GtkLabel2 = new global::Gtk.Label ();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Source</b>");
		this.GtkLabel2.UseMarkup = true;
		this.frame4.LabelWidget = this.GtkLabel2;
		this.vbox1.Add (this.frame4);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame4]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		w5.Padding = ((uint)(4));
		// Container child vbox1.Gtk.Box+BoxChild
		this.installedfontsframe = new global::Gtk.Frame ();
		this.installedfontsframe.Name = "installedfontsframe";
		this.installedfontsframe.ShadowType = ((global::Gtk.ShadowType)(2));
		// Container child installedfontsframe.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		this.GtkAlignment1.TopPadding = ((uint)(2));
		this.GtkAlignment1.RightPadding = ((uint)(12));
		this.GtkAlignment1.BottomPadding = ((uint)(2));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.installedfontscombobox = global::Gtk.ComboBox.NewText ();
		this.installedfontscombobox.Name = "installedfontscombobox";
		this.GtkAlignment1.Add (this.installedfontscombobox);
		this.installedfontsframe.Add (this.GtkAlignment1);
		this.GtkLabel3 = new global::Gtk.Label ();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Installed Fonts</b>");
		this.GtkLabel3.UseMarkup = true;
		this.installedfontsframe.LabelWidget = this.GtkLabel3;
		this.vbox1.Add (this.installedfontsframe);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.installedfontsframe]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		w8.Padding = ((uint)(4));
		// Container child vbox1.Gtk.Box+BoxChild
		this.fromfileframe = new global::Gtk.Frame ();
		this.fromfileframe.Sensitive = false;
		this.fromfileframe.Name = "fromfileframe";
		this.fromfileframe.ShadowType = ((global::Gtk.ShadowType)(2));
		// Container child fromfileframe.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		this.GtkAlignment2.TopPadding = ((uint)(2));
		this.GtkAlignment2.RightPadding = ((uint)(12));
		this.GtkAlignment2.BottomPadding = ((uint)(2));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.fontfilechooserbutton = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select a File"), ((global::Gtk.FileChooserAction)(0)));
		this.fontfilechooserbutton.Name = "fontfilechooserbutton";
		this.GtkAlignment2.Add (this.fontfilechooserbutton);
		this.fromfileframe.Add (this.GtkAlignment2);
		this.GtkLabel5 = new global::Gtk.Label ();
		this.GtkLabel5.Name = "GtkLabel5";
		this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>From File</b>");
		this.GtkLabel5.UseMarkup = true;
		this.fromfileframe.LabelWidget = this.GtkLabel5;
		this.vbox1.Add (this.fromfileframe);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.fromfileframe]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		w11.Padding = ((uint)(4));
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(2));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		this.GtkAlignment.TopPadding = ((uint)(2));
		this.GtkAlignment.RightPadding = ((uint)(12));
		this.GtkAlignment.BottomPadding = ((uint)(2));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.sizelabel1 = new global::Gtk.Label ();
		this.sizelabel1.Name = "sizelabel1";
		this.sizelabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("Size:");
		this.hbox7.Add (this.sizelabel1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.sizelabel1]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.sizespinbutton = new global::Gtk.SpinButton (0, 100, 1);
		this.sizespinbutton.CanFocus = true;
		this.sizespinbutton.Name = "sizespinbutton";
		this.sizespinbutton.Adjustment.PageIncrement = 10;
		this.sizespinbutton.ClimbRate = 1;
		this.sizespinbutton.Numeric = true;
		this.sizespinbutton.Value = 8;
		this.hbox7.Add (this.sizespinbutton);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.sizespinbutton]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		this.vbox4.Add (this.hbox7);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox7]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.antialiasingcheckbutton = new global::Gtk.CheckButton ();
		this.antialiasingcheckbutton.CanFocus = true;
		this.antialiasingcheckbutton.Name = "antialiasingcheckbutton";
		this.antialiasingcheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Anti-aliasing");
		this.antialiasingcheckbutton.DrawIndicator = true;
		this.antialiasingcheckbutton.UseUnderline = true;
		this.vbox4.Add (this.antialiasingcheckbutton);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.antialiasingcheckbutton]));
		w15.Position = 1;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Font Colour:");
		this.hbox2.Add (this.label4);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label4]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.fontcolorbutton = new global::Gtk.ColorButton ();
		this.fontcolorbutton.CanFocus = true;
		this.fontcolorbutton.Events = ((global::Gdk.EventMask)(784));
		this.fontcolorbutton.Name = "fontcolorbutton";
		this.hbox2.Add (this.fontcolorbutton);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fontcolorbutton]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		this.vbox4.Add (this.hbox2);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
		w18.Position = 2;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.Xalign = 0F;
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Background Colour:");
		this.vbox4.Add (this.label5);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label5]));
		w19.Position = 3;
		w19.Expand = false;
		w19.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.transparentbackgroundcheckbutton = new global::Gtk.CheckButton ();
		this.transparentbackgroundcheckbutton.CanFocus = true;
		this.transparentbackgroundcheckbutton.Name = "transparentbackgroundcheckbutton";
		this.transparentbackgroundcheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Transparent");
		this.transparentbackgroundcheckbutton.Active = true;
		this.transparentbackgroundcheckbutton.DrawIndicator = true;
		this.transparentbackgroundcheckbutton.UseUnderline = true;
		this.hbox6.Add (this.transparentbackgroundcheckbutton);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.transparentbackgroundcheckbutton]));
		w20.Position = 0;
		// Container child hbox6.Gtk.Box+BoxChild
		this.backgroundcolorbutton = new global::Gtk.ColorButton ();
		this.backgroundcolorbutton.Sensitive = false;
		this.backgroundcolorbutton.CanFocus = true;
		this.backgroundcolorbutton.Events = ((global::Gdk.EventMask)(784));
		this.backgroundcolorbutton.Name = "backgroundcolorbutton";
		this.hbox6.Add (this.backgroundcolorbutton);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.backgroundcolorbutton]));
		w21.Position = 1;
		w21.Expand = false;
		w21.Fill = false;
		this.vbox4.Add (this.hbox6);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox6]));
		w22.Position = 4;
		w22.Expand = false;
		w22.Fill = false;
		this.GtkAlignment.Add (this.vbox4);
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel11 = new global::Gtk.Label ();
		this.GtkLabel11.Name = "GtkLabel11";
		this.GtkLabel11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>General</b>");
		this.GtkLabel11.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel11;
		this.vbox1.Add (this.frame1);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
		w25.PackType = ((global::Gtk.PackType)(1));
		w25.Position = 3;
		this.hbox1.Add (this.vbox1);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
		w26.Position = 0;
		w26.Expand = false;
		w26.Padding = ((uint)(4));
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.outputframe = new global::Gtk.Frame ();
		this.outputframe.Name = "outputframe";
		this.outputframe.ShadowType = ((global::Gtk.ShadowType)(2));
		// Container child outputframe.Gtk.Container+ContainerChild
		this.GtkAlignment8 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment8.Name = "GtkAlignment8";
		this.GtkAlignment8.LeftPadding = ((uint)(12));
		this.GtkAlignment8.TopPadding = ((uint)(2));
		this.GtkAlignment8.RightPadding = ((uint)(12));
		this.GtkAlignment8.BottomPadding = ((uint)(2));
		// Container child GtkAlignment8.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.previewbutton = new global::Gtk.Button ();
		this.previewbutton.CanFocus = true;
		this.previewbutton.Name = "previewbutton";
		this.previewbutton.UseUnderline = true;
		this.previewbutton.Label = global::Mono.Unix.Catalog.GetString ("Preview");
		this.vbox6.Add (this.previewbutton);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.previewbutton]));
		w27.Position = 0;
		w27.Expand = false;
		w27.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.previewimage = new global::Gtk.Image ();
		this.previewimage.Name = "previewimage";
		this.hbox3.Add (this.previewimage);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.previewimage]));
		w28.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(2));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment9 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment9.Name = "GtkAlignment9";
		this.GtkAlignment9.LeftPadding = ((uint)(12));
		this.GtkAlignment9.RightPadding = ((uint)(12));
		// Container child GtkAlignment9.Gtk.Container+ContainerChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Xalign = 0F;
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Width:");
		this.hbox4.Add (this.label1);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label1]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.labelWidth = new global::Gtk.Label ();
		this.labelWidth.Name = "labelWidth";
		this.hbox4.Add (this.labelWidth);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelWidth]));
		w30.PackType = ((global::Gtk.PackType)(1));
		w30.Position = 1;
		w30.Expand = false;
		w30.Fill = false;
		this.vbox5.Add (this.hbox4);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox4]));
		w31.Position = 0;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 0F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Height:");
		this.hbox5.Add (this.label2);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label2]));
		w32.Position = 0;
		w32.Expand = false;
		w32.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.labelHeight = new global::Gtk.Label ();
		this.labelHeight.Name = "labelHeight";
		this.hbox5.Add (this.labelHeight);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.labelHeight]));
		w33.PackType = ((global::Gtk.PackType)(1));
		w33.Position = 1;
		w33.Expand = false;
		w33.Fill = false;
		this.vbox5.Add (this.hbox5);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox5]));
		w34.Position = 1;
		w34.Expand = false;
		w34.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox ();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.Xalign = 0F;
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Cell Size:");
		this.hbox8.Add (this.label3);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label3]));
		w35.Position = 0;
		w35.Expand = false;
		w35.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.labelCellSize = new global::Gtk.Label ();
		this.labelCellSize.Name = "labelCellSize";
		this.hbox8.Add (this.labelCellSize);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.labelCellSize]));
		w36.PackType = ((global::Gtk.PackType)(1));
		w36.Position = 1;
		w36.Expand = false;
		w36.Fill = false;
		this.vbox5.Add (this.hbox8);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox8]));
		w37.Position = 2;
		w37.Expand = false;
		w37.Fill = false;
		this.GtkAlignment9.Add (this.vbox5);
		this.frame2.Add (this.GtkAlignment9);
		this.GtkLabel10 = new global::Gtk.Label ();
		this.GtkLabel10.Name = "GtkLabel10";
		this.GtkLabel10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Details</b>");
		this.GtkLabel10.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel10;
		this.hbox3.Add (this.frame2);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.frame2]));
		w40.Position = 1;
		w40.Expand = false;
		w40.Fill = false;
		w40.Padding = ((uint)(4));
		this.vbox6.Add (this.hbox3);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox3]));
		w41.Position = 1;
		// Container child vbox6.Gtk.Box+BoxChild
		this.generatebutton = new global::Gtk.Button ();
		this.generatebutton.Sensitive = false;
		this.generatebutton.CanFocus = true;
		this.generatebutton.Name = "generatebutton";
		this.generatebutton.UseUnderline = true;
		this.generatebutton.Label = global::Mono.Unix.Catalog.GetString ("Save");
		this.vbox6.Add (this.generatebutton);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.generatebutton]));
		w42.PackType = ((global::Gtk.PackType)(1));
		w42.Position = 2;
		w42.Expand = false;
		w42.Fill = false;
		this.GtkAlignment8.Add (this.vbox6);
		this.outputframe.Add (this.GtkAlignment8);
		this.GtkLabel14 = new global::Gtk.Label ();
		this.GtkLabel14.Name = "GtkLabel14";
		this.GtkLabel14.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Output</b>");
		this.GtkLabel14.UseMarkup = true;
		this.outputframe.LabelWidget = this.GtkLabel14;
		this.vbox2.Add (this.outputframe);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.outputframe]));
		w45.PackType = ((global::Gtk.PackType)(1));
		w45.Position = 0;
		w45.Padding = ((uint)(4));
		this.hbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
		w46.Position = 1;
		w46.Padding = ((uint)(4));
		this.Add (this.hbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 826;
		this.DefaultHeight = 523;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
