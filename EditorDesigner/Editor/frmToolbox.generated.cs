
//This code generated by tool. Do not hand update!
//ALSO DO NOT DELETE OR YOU WILL LOOSE YOUR FORM!
namespace uAssist.EditorDesigner
{
    using UnityEngine;
    using UnityEditor;
    using System.Collections;
    using System.Collections.Generic;
    using uAssist.UEditorWidgets;
    using uAssist.UEditorWidgets.Internal;
    using uAssist.Forms;

    [UWidgetForm]
    public partial class frmToolbox : frmBase
    {



        //Widget declarations
		private UEditorPanelVertical _winMasterLayout = UWidget.Create<UEditorPanelVertical>();
		private UEditorDecoratorSeperator LayoutSpacer = UWidget.Create<UEditorDecoratorSeperator>();
		private UEditorWidgetLabel LabelControl = UWidget.Create<UEditorWidgetLabel>();
		private UEditorWidgetLabel _lblActiveContainter = UWidget.Create<UEditorWidgetLabel>();
		private UEditorPanelTab TabPanel = UWidget.Create<UEditorPanelTab>();
		private UEditorPanelHorizonal HorizontalLayout = UWidget.Create<UEditorPanelHorizonal>();
		private UEditorPanelVertical TabPanel_Hierarchy = UWidget.Create<UEditorPanelVertical>();
		private UEditorPanelVertical TabPanel_Toolbox = UWidget.Create<UEditorPanelVertical>();
		private UControlDesignerTools _toolbox = UWidget.Create<UControlDesignerTools>();
		private UEditorPanelVertical _hierarchyWindow = UWidget.Create<UEditorPanelVertical>();
		private UEditorPanelScroll _hierarchyScroll = UWidget.Create<UEditorPanelScroll>();
		public UEditorWidgetFoldout __widgetDesignerRoot = UWidget.Create<UEditorWidgetFoldout>();


        public override void InitalizeComponents()
        {

        //Form settings
		this.name = "frmToolbox";
		this.FormTitle = "Designer TB";
		this.MaxHeight = -1;
		this.MaxWidth = -1;
		this.InspectorUpdateRender = true;
		this.DesignerDropOverridePath = @"Assets\uAssist\EditorDesigner\Editor\";
		this.DesignerNameSpace = @"uAssist.EditorDesigner";
		this.AutoMenuOption = true;

            
        //Property settings
		//Property setters for ->_winMasterLayout
		this._winMasterLayout.BaseStyle = "";
		this._winMasterLayout.Clipping = UnityEngine.TextClipping.Overflow;
		this._winMasterLayout.Margin.top = 0;
		this._winMasterLayout.Margin.bottom = 0;
		this._winMasterLayout.Margin.left = 0;
		this._winMasterLayout.Margin.right = 0;
		this._winMasterLayout.Padding.top = 0;
		this._winMasterLayout.Padding.bottom = 0;
		this._winMasterLayout.Padding.left = 0;
		this._winMasterLayout.Padding.right = 0;
		this._winMasterLayout.Border.top = 0;
		this._winMasterLayout.Border.bottom = 0;
		this._winMasterLayout.Border.left = 0;
		this._winMasterLayout.Border.right = 0;
		this._winMasterLayout.Height = -1f;
		this._winMasterLayout.Width = 340f;
		this._winMasterLayout.Name = "_winMasterLayout";
		this._winMasterLayout.ChildrenShouldRender = true;
		this._winMasterLayout.WidgetScope = "private";
		this._winMasterLayout.PositionX = 1f;
		this._winMasterLayout.PositionY = 1f;
		this._winMasterLayout.GUIEnabled = true;
		this._winMasterLayout.WidgetShouldRender = true;
		this._winMasterLayout.LayoutExpandHeight = false;
		this._winMasterLayout.LayoutExpandWidth = false;
		this._winMasterLayout.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.AddChild(this._winMasterLayout, true);
	
	
		//Property setters for ->LayoutSpacer
		this.LayoutSpacer.BaseStyle = "";
		this.LayoutSpacer.Clipping = UnityEngine.TextClipping.Overflow;
		this.LayoutSpacer.Margin.top = 0;
		this.LayoutSpacer.Margin.bottom = 0;
		this.LayoutSpacer.Margin.left = 0;
		this.LayoutSpacer.Margin.right = 0;
		this.LayoutSpacer.Padding.top = 0;
		this.LayoutSpacer.Padding.bottom = 0;
		this.LayoutSpacer.Padding.left = 0;
		this.LayoutSpacer.Padding.right = 0;
		this.LayoutSpacer.Border.top = 0;
		this.LayoutSpacer.Border.bottom = 0;
		this.LayoutSpacer.Border.left = 0;
		this.LayoutSpacer.Border.right = 0;
		this.LayoutSpacer.Height = -1f;
		this.LayoutSpacer.Width = 340f;
		this.LayoutSpacer.Name = "LayoutSpacer";
		this.LayoutSpacer.SeperatorLines = 1;
		this.LayoutSpacer.WidgetScope = "private";
		this.LayoutSpacer.PositionX = 1f;
		this.LayoutSpacer.PositionY = 1f;
		this.LayoutSpacer.GUIEnabled = true;
		this.LayoutSpacer.WidgetShouldRender = true;
		this.LayoutSpacer.LayoutExpandHeight = false;
		this.LayoutSpacer.LayoutExpandWidth = false;
		this.LayoutSpacer.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.WindowSpace;
		this._winMasterLayout.AddChild(this.LayoutSpacer);
	
	
		//Property setters for ->LabelControl
		this.LabelControl.Label = "Designer Toolbox";
		this.LabelControl.FontSize = 11;
		this.LabelControl.FontStyle = UnityEngine.FontStyle.Bold;
		this.LabelControl.WordWrap = false;
		this.LabelControl.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this.LabelControl.BaseStyle = "";
		this.LabelControl.Clipping = UnityEngine.TextClipping.Overflow;
		this.LabelControl.Margin.top = 2;
		this.LabelControl.Margin.bottom = 2;
		this.LabelControl.Margin.left = 4;
		this.LabelControl.Margin.right = 4;
		this.LabelControl.Padding.top = 1;
		this.LabelControl.Padding.bottom = 2;
		this.LabelControl.Padding.left = 3;
		this.LabelControl.Padding.right = 3;
		this.LabelControl.Border.top = 3;
		this.LabelControl.Border.bottom = 3;
		this.LabelControl.Border.left = 3;
		this.LabelControl.Border.right = 3;
		this.LabelControl.Height = 20f;
		this.LabelControl.Width = 340f;
		this.LabelControl.Name = "LabelControl";
		this.LabelControl.WidgetScope = "private";
		this.LabelControl.PositionX = 1f;
		this.LabelControl.PositionY = 1f;
		this.LabelControl.GUIEnabled = true;
		this.LabelControl.WidgetShouldRender = true;
		this.LabelControl.LayoutExpandHeight = false;
		this.LabelControl.LayoutExpandWidth = false;
		this.LabelControl.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._winMasterLayout.AddChild(this.LabelControl);
	
	
		//Property setters for ->_lblActiveContainter
		this._lblActiveContainter.Label = "";
		this._lblActiveContainter.FontSize = 15;
		this._lblActiveContainter.FontStyle = UnityEngine.FontStyle.Normal;
		this._lblActiveContainter.WordWrap = false;
		this._lblActiveContainter.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this._lblActiveContainter.BaseStyle = "";
		this._lblActiveContainter.Clipping = UnityEngine.TextClipping.Overflow;
		this._lblActiveContainter.Margin.top = 2;
		this._lblActiveContainter.Margin.bottom = 2;
		this._lblActiveContainter.Margin.left = 4;
		this._lblActiveContainter.Margin.right = 4;
		this._lblActiveContainter.Padding.top = 1;
		this._lblActiveContainter.Padding.bottom = 2;
		this._lblActiveContainter.Padding.left = 10;
		this._lblActiveContainter.Padding.right = 3;
		this._lblActiveContainter.Border.top = 3;
		this._lblActiveContainter.Border.bottom = 3;
		this._lblActiveContainter.Border.left = 3;
		this._lblActiveContainter.Border.right = 3;
		this._lblActiveContainter.Height = 15f;
		this._lblActiveContainter.Width = 340f;
		this._lblActiveContainter.Name = "_lblActiveContainter";
		this._lblActiveContainter.WidgetScope = "private";
		this._lblActiveContainter.PositionX = 1f;
		this._lblActiveContainter.PositionY = 1f;
		this._lblActiveContainter.GUIEnabled = true;
		this._lblActiveContainter.WidgetShouldRender = true;
		this._lblActiveContainter.LayoutExpandHeight = false;
		this._lblActiveContainter.LayoutExpandWidth = false;
		this._lblActiveContainter.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._winMasterLayout.AddChild(this._lblActiveContainter);
	
	
		//Property setters for ->TabPanel
		this.TabPanel.BaseStyle = "";
		this.TabPanel.Clipping = UnityEngine.TextClipping.Overflow;
		this.TabPanel.Margin.top = 0;
		this.TabPanel.Margin.bottom = 0;
		this.TabPanel.Margin.left = 0;
		this.TabPanel.Margin.right = 0;
		this.TabPanel.Padding.top = 0;
		this.TabPanel.Padding.bottom = 0;
		this.TabPanel.Padding.left = 0;
		this.TabPanel.Padding.right = 0;
		this.TabPanel.Border.top = 0;
		this.TabPanel.Border.bottom = 0;
		this.TabPanel.Border.left = 0;
		this.TabPanel.Border.right = 0;
		this.TabPanel.Height = 444f;
		this.TabPanel.Width = 250f;
		this.TabPanel.Name = "TabPanel";
		this.TabPanel.ToolBar.FontSize = 11;
		this.TabPanel.ToolBar.FontStyle = UnityEngine.FontStyle.Normal;
		this.TabPanel.ToolBar.WordWrap = false;
		this.TabPanel.ToolBar.Alignment = UnityEngine.TextAnchor.MiddleCenter;
		this.TabPanel.ToolBar.BaseStyle = "button";
		this.TabPanel.ToolBar.Clipping = UnityEngine.TextClipping.Overflow;
		this.TabPanel.ToolBar.Margin.top = 2;
		this.TabPanel.ToolBar.Margin.bottom = 2;
		this.TabPanel.ToolBar.Margin.left = 4;
		this.TabPanel.ToolBar.Margin.right = 4;
		this.TabPanel.ToolBar.Padding.top = 1;
		this.TabPanel.ToolBar.Padding.bottom = 2;
		this.TabPanel.ToolBar.Padding.left = 3;
		this.TabPanel.ToolBar.Padding.right = 3;
		this.TabPanel.ToolBar.Border.top = 3;
		this.TabPanel.ToolBar.Border.bottom = 3;
		this.TabPanel.ToolBar.Border.left = 3;
		this.TabPanel.ToolBar.Border.right = 3;
		this.TabPanel.ToolBar.Height = 20f;
		this.TabPanel.ToolBar.Width = 120f;
		this.TabPanel.ToolBar.Name = "ToolBar";
		this.TabPanel.ToolBar.WidgetScope = "private";
		this.TabPanel.ToolBar.PositionX = 1f;
		this.TabPanel.ToolBar.PositionY = 1f;
		this.TabPanel.ToolBar.GUIEnabled = true;
		this.TabPanel.ToolBar.WidgetShouldRender = true;
		this.TabPanel.ToolBar.LayoutExpandHeight = false;
		this.TabPanel.ToolBar.LayoutExpandWidth = false;
		this.TabPanel.ToolBar.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.TabPanel.ToolBar.MenuOptions.Clear();
		this.TabPanel.ToolBar.MenuOptions.Add("Hierarchy");
		this.TabPanel.TabPanelData.Add(new UEditorPanelTab_TabPanelItem() { DisplayName = "Hierarchy", parent = this.TabPanel });
		this.TabPanel.ToolBar.MenuOptions.Add("Toolbox");
		this.TabPanel.TabPanelData.Add(new UEditorPanelTab_TabPanelItem() { DisplayName = "Toolbox", parent = this.TabPanel });
		this.TabPanel.ChildrenShouldRender = true;
		this.TabPanel.WidgetScope = "private";
		this.TabPanel.PositionX = 35f;
		this.TabPanel.PositionY = 60f;
		this.TabPanel.GUIEnabled = true;
		this.TabPanel.WidgetShouldRender = false;
		this.TabPanel.LayoutExpandHeight = false;
		this.TabPanel.LayoutExpandWidth = false;
		this.TabPanel.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.WindowSpace;
		this._winMasterLayout.AddChild(this.TabPanel);
	
	
		//Property setters for ->HorizontalLayout
		this.HorizontalLayout.BaseStyle = "";
		this.HorizontalLayout.Clipping = UnityEngine.TextClipping.Overflow;
		this.HorizontalLayout.Margin.top = 5;
		this.HorizontalLayout.Margin.bottom = 0;
		this.HorizontalLayout.Margin.left = 0;
		this.HorizontalLayout.Margin.right = 0;
		this.HorizontalLayout.Padding.top = 0;
		this.HorizontalLayout.Padding.bottom = 0;
		this.HorizontalLayout.Padding.left = 0;
		this.HorizontalLayout.Padding.right = 0;
		this.HorizontalLayout.Border.top = 0;
		this.HorizontalLayout.Border.bottom = 0;
		this.HorizontalLayout.Border.left = 0;
		this.HorizontalLayout.Border.right = 0;
		this.HorizontalLayout.Height = -1f;
		this.HorizontalLayout.Width = -1f;
		this.HorizontalLayout.Name = "HorizontalLayout";
		this.HorizontalLayout.ChildrenShouldRender = true;
		this.HorizontalLayout.WidgetScope = "private";
		this.HorizontalLayout.PositionX = 1f;
		this.HorizontalLayout.PositionY = 1f;
		this.HorizontalLayout.GUIEnabled = true;
		this.HorizontalLayout.WidgetShouldRender = true;
		this.HorizontalLayout.LayoutExpandHeight = false;
		this.HorizontalLayout.LayoutExpandWidth = false;
		this.HorizontalLayout.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._winMasterLayout.AddChild(this.HorizontalLayout);
	
	
		//Property setters for ->TabPanel_Hierarchy
		this.TabPanel_Hierarchy.BaseStyle = "";
		this.TabPanel_Hierarchy.Clipping = UnityEngine.TextClipping.Overflow;
		this.TabPanel_Hierarchy.Margin.top = 0;
		this.TabPanel_Hierarchy.Margin.bottom = 0;
		this.TabPanel_Hierarchy.Margin.left = 0;
		this.TabPanel_Hierarchy.Margin.right = 0;
		this.TabPanel_Hierarchy.Padding.top = 0;
		this.TabPanel_Hierarchy.Padding.bottom = 0;
		this.TabPanel_Hierarchy.Padding.left = 25;
		this.TabPanel_Hierarchy.Padding.right = 0;
		this.TabPanel_Hierarchy.Border.top = 0;
		this.TabPanel_Hierarchy.Border.bottom = 0;
		this.TabPanel_Hierarchy.Border.left = 0;
		this.TabPanel_Hierarchy.Border.right = 0;
		this.TabPanel_Hierarchy.Height = 500f;
		this.TabPanel_Hierarchy.Width = 210f;
		this.TabPanel_Hierarchy.Name = "TabPanel_Hierarchy";
		this.TabPanel_Hierarchy.ChildrenShouldRender = true;
		this.TabPanel_Hierarchy.WidgetScope = "private";
		this.TabPanel_Hierarchy.PositionX = 1f;
		this.TabPanel_Hierarchy.PositionY = 1f;
		this.TabPanel_Hierarchy.GUIEnabled = true;
		this.TabPanel_Hierarchy.WidgetShouldRender = true;
		this.TabPanel_Hierarchy.LayoutExpandHeight = false;
		this.TabPanel_Hierarchy.LayoutExpandWidth = false;
		this.TabPanel_Hierarchy.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.TabPanel.AddChild(this.TabPanel_Hierarchy);
	
	
		//Property setters for ->TabPanel_Toolbox
		this.TabPanel_Toolbox.BaseStyle = "";
		this.TabPanel_Toolbox.Clipping = UnityEngine.TextClipping.Overflow;
		this.TabPanel_Toolbox.Margin.top = 0;
		this.TabPanel_Toolbox.Margin.bottom = 0;
		this.TabPanel_Toolbox.Margin.left = 0;
		this.TabPanel_Toolbox.Margin.right = 0;
		this.TabPanel_Toolbox.Padding.top = 0;
		this.TabPanel_Toolbox.Padding.bottom = 0;
		this.TabPanel_Toolbox.Padding.left = 25;
		this.TabPanel_Toolbox.Padding.right = 0;
		this.TabPanel_Toolbox.Border.top = 0;
		this.TabPanel_Toolbox.Border.bottom = 0;
		this.TabPanel_Toolbox.Border.left = 0;
		this.TabPanel_Toolbox.Border.right = 0;
		this.TabPanel_Toolbox.Height = 500f;
		this.TabPanel_Toolbox.Width = 210f;
		this.TabPanel_Toolbox.Name = "TabPanel_Toolbox";
		this.TabPanel_Toolbox.ChildrenShouldRender = true;
		this.TabPanel_Toolbox.WidgetScope = "private";
		this.TabPanel_Toolbox.PositionX = 0f;
		this.TabPanel_Toolbox.PositionY = 0f;
		this.TabPanel_Toolbox.GUIEnabled = true;
		this.TabPanel_Toolbox.WidgetShouldRender = false;
		this.TabPanel_Toolbox.LayoutExpandHeight = false;
		this.TabPanel_Toolbox.LayoutExpandWidth = false;
		this.TabPanel_Toolbox.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.TabPanel.AddChild(this.TabPanel_Toolbox);
	
	
		//Property setters for ->_toolbox
		this._toolbox.BaseStyle = "";
		this._toolbox.Clipping = UnityEngine.TextClipping.Overflow;
		this._toolbox.Margin.top = 0;
		this._toolbox.Margin.bottom = 0;
		this._toolbox.Margin.left = 5;
		this._toolbox.Margin.right = 0;
		this._toolbox.Padding.top = 0;
		this._toolbox.Padding.bottom = 0;
		this._toolbox.Padding.left = 0;
		this._toolbox.Padding.right = 0;
		this._toolbox.Border.top = 0;
		this._toolbox.Border.bottom = 0;
		this._toolbox.Border.left = 0;
		this._toolbox.Border.right = 0;
		this._toolbox.Height = -1f;
		this._toolbox.Width = 120f;
		this._toolbox.Name = "_toolbox";
		this._toolbox.WidgetScope = "private";
		this._toolbox.PositionX = 1f;
		this._toolbox.PositionY = 1f;
		this._toolbox.GUIEnabled = true;
		this._toolbox.WidgetShouldRender = true;
		this._toolbox.LayoutExpandHeight = false;
		this._toolbox.LayoutExpandWidth = false;
		this._toolbox.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.HorizontalLayout.AddChild(this._toolbox);
	
	
		//Property setters for ->_hierarchyWindow
		this._hierarchyWindow.BaseStyle = "textField";
		this._hierarchyWindow.Clipping = UnityEngine.TextClipping.Overflow;
		this._hierarchyWindow.Margin.top = 0;
		this._hierarchyWindow.Margin.bottom = 0;
		this._hierarchyWindow.Margin.left = 5;
		this._hierarchyWindow.Margin.right = 0;
		this._hierarchyWindow.Padding.top = 0;
		this._hierarchyWindow.Padding.bottom = 0;
		this._hierarchyWindow.Padding.left = 0;
		this._hierarchyWindow.Padding.right = 0;
		this._hierarchyWindow.Border.top = 3;
		this._hierarchyWindow.Border.bottom = 3;
		this._hierarchyWindow.Border.left = 3;
		this._hierarchyWindow.Border.right = 3;
		this._hierarchyWindow.Height = 400f;
		this._hierarchyWindow.Width = 200f;
		this._hierarchyWindow.Name = "_hierarchyWindow";
		this._hierarchyWindow.ChildrenShouldRender = true;
		this._hierarchyWindow.WidgetScope = "private";
		this._hierarchyWindow.PositionX = 1f;
		this._hierarchyWindow.PositionY = 1f;
		this._hierarchyWindow.GUIEnabled = true;
		this._hierarchyWindow.WidgetShouldRender = true;
		this._hierarchyWindow.LayoutExpandHeight = false;
		this._hierarchyWindow.LayoutExpandWidth = false;
		this._hierarchyWindow.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.HorizontalLayout.AddChild(this._hierarchyWindow);
	
	
		//Property setters for ->_hierarchyScroll
		this._hierarchyScroll.BaseStyle = "";
		this._hierarchyScroll.Clipping = UnityEngine.TextClipping.Overflow;
		this._hierarchyScroll.Margin.top = 0;
		this._hierarchyScroll.Margin.bottom = 0;
		this._hierarchyScroll.Margin.left = 0;
		this._hierarchyScroll.Margin.right = 0;
		this._hierarchyScroll.Padding.top = 0;
		this._hierarchyScroll.Padding.bottom = 0;
		this._hierarchyScroll.Padding.left = 0;
		this._hierarchyScroll.Padding.right = 0;
		this._hierarchyScroll.Border.top = 0;
		this._hierarchyScroll.Border.bottom = 0;
		this._hierarchyScroll.Border.left = 0;
		this._hierarchyScroll.Border.right = 0;
		this._hierarchyScroll.Height = -1f;
		this._hierarchyScroll.Width = 200f;
		this._hierarchyScroll.Name = "_hierarchyScroll";
		this._hierarchyScroll.ChildrenShouldRender = true;
		this._hierarchyScroll.WidgetScope = "private";
		this._hierarchyScroll.PositionX = 1f;
		this._hierarchyScroll.PositionY = 1f;
		this._hierarchyScroll.GUIEnabled = true;
		this._hierarchyScroll.WidgetShouldRender = true;
		this._hierarchyScroll.LayoutExpandHeight = false;
		this._hierarchyScroll.LayoutExpandWidth = false;
		this._hierarchyScroll.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._hierarchyWindow.AddChild(this._hierarchyScroll);
	
	
		//Property setters for ->__widgetDesignerRoot
		this.__widgetDesignerRoot.FoldoutOpen = true;
		this.__widgetDesignerRoot.FontSize = 12;
		this.__widgetDesignerRoot.FontStyle = UnityEngine.FontStyle.Bold;
		this.__widgetDesignerRoot.Label = "Form Layout";
		this.__widgetDesignerRoot.BaseStyle = "";
		this.__widgetDesignerRoot.Clipping = UnityEngine.TextClipping.Overflow;
		this.__widgetDesignerRoot.Margin.top = 0;
		this.__widgetDesignerRoot.Margin.bottom = 0;
		this.__widgetDesignerRoot.Margin.left = 1;
		this.__widgetDesignerRoot.Margin.right = 0;
		this.__widgetDesignerRoot.Padding.top = 0;
		this.__widgetDesignerRoot.Padding.bottom = 0;
		this.__widgetDesignerRoot.Padding.left = 15;
		this.__widgetDesignerRoot.Padding.right = 0;
		this.__widgetDesignerRoot.Border.top = 13;
		this.__widgetDesignerRoot.Border.bottom = 0;
		this.__widgetDesignerRoot.Border.left = 14;
		this.__widgetDesignerRoot.Border.right = 0;
		this.__widgetDesignerRoot.Height = -1f;
		this.__widgetDesignerRoot.Width = 200f;
		this.__widgetDesignerRoot.Name = "__widgetDesignerRoot";
		this.__widgetDesignerRoot.IndentLevel = 0;
		this.__widgetDesignerRoot.IndentDepth = 10;
		this.__widgetDesignerRoot.DefaultWidth = 200f;
		this.__widgetDesignerRoot.ToggleOnLabelClick = true;
		this.__widgetDesignerRoot.Override_AlwaysOpen = true;
		this.__widgetDesignerRoot.ChildrenShouldRender = true;
		this.__widgetDesignerRoot.WidgetScope = "public";
		this.__widgetDesignerRoot.PositionX = 1f;
		this.__widgetDesignerRoot.PositionY = 1f;
		this.__widgetDesignerRoot.GUIEnabled = true;
		this.__widgetDesignerRoot.WidgetShouldRender = true;
		this.__widgetDesignerRoot.LayoutExpandHeight = false;
		this.__widgetDesignerRoot.LayoutExpandWidth = false;
		this.__widgetDesignerRoot.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._hierarchyScroll.AddChild(this.__widgetDesignerRoot);
	
	


        }

    }
}