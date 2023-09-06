namespace MedicineDatabase.MedicineInformation.Views
{
    partial class PillsDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PillsDetailForm));
            pillDetailTooltip = new ToolTip(components);
            detailFormMainLayout = new TableLayoutPanel();
            simmilarPanel = new Panel();
            simmilarListLayoutPanel = new FlowLayoutPanel();
            simmilarLabel = new Label();
            additionalDetailLayout = new TableLayoutPanel();
            substancesText = new TextBox();
            overodeText = new TextBox();
            compositionText = new TextBox();
            dosageText = new TextBox();
            interactionsText = new TextBox();
            warningsText = new TextBox();
            applicabilityText = new TextBox();
            sideeffectsText = new TextBox();
            indicationsText = new TextBox();
            additionalDetailLabel = new Label();
            pillDocumentIndicationsLabel = new Label();
            pillDocumentContraindicationsLabel = new Label();
            pillDocumentSideEffectLabel = new Label();
            pillDocumentApplicabilityLabel = new Label();
            pillDocumentWarningsLabel = new Label();
            pillDocumentInteractionsLabel = new Label();
            pillDocumentDosageLabel = new Label();
            pillDocumentCompositionLabel = new Label();
            pillDocumentOverdoseLabel = new Label();
            pillDocumentSubstancesLabel = new Label();
            contraindicationsText = new TextBox();
            pillDetailLayoutPanel = new TableLayoutPanel();
            pillSuklText = new Label();
            pillSklLabel = new Label();
            pillMedicalSubstancesText = new Label();
            pillExpirationLabel = new Label();
            pillUnlimitedRegistartionLabel = new Label();
            pillRegistartionHolderCountraLabel = new Label();
            pillRegistrationHolderLabel = new Label();
            pillRegistrationNumberLabel = new Label();
            pillATCNameLabel = new Label();
            pillATCCodeLabel = new Label();
            pillDispensingLabel = new Label();
            pillCoverLabel = new Label();
            pillWayOfUseLabel = new Label();
            pillPackingLabel = new Label();
            pillFormLabel = new Label();
            pillSupplementLabel = new Label();
            pillPowerLabel = new Label();
            pillNameLabel = new Label();
            pillPowerText = new Label();
            pillSupplementText = new Label();
            pillFormText = new Label();
            pillPackingText = new Label();
            pillWayOfUseText = new Label();
            pillCoverText = new Label();
            pillDispensingText = new Label();
            pillATCCodeText = new Label();
            pillAtcNameText = new Label();
            pillRegistrationNumberText = new Label();
            pillRegistrationHolderText = new Label();
            pillRegistrationHolderCountryText = new Label();
            pillUnlimitedRegistrationText = new Label();
            pillExpirationText = new Label();
            pillDocumentsLabel = new Label();
            pillMedicalSubstancesLabel = new Label();
            openPillDocumentButton = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            pillAddToListButton = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            pillsDetailWarningLabel = new Label();
            goBackToSearchButton = new MaterialSkin.Controls.MaterialButton();
            pillDetailsHelpButton = new MaterialSkin.Controls.MaterialButton();
            detailFormMainLayout.SuspendLayout();
            simmilarPanel.SuspendLayout();
            additionalDetailLayout.SuspendLayout();
            pillDetailLayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pillDetailTooltip
            // 
            pillDetailTooltip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // detailFormMainLayout
            // 
            resources.ApplyResources(detailFormMainLayout, "detailFormMainLayout");
            detailFormMainLayout.Controls.Add(simmilarPanel, 1, 0);
            detailFormMainLayout.Controls.Add(additionalDetailLayout, 0, 1);
            detailFormMainLayout.Controls.Add(pillDetailLayoutPanel, 0, 0);
            detailFormMainLayout.Name = "detailFormMainLayout";
            // 
            // simmilarPanel
            // 
            simmilarPanel.BackColor = Color.White;
            simmilarPanel.Controls.Add(simmilarListLayoutPanel);
            simmilarPanel.Controls.Add(simmilarLabel);
            resources.ApplyResources(simmilarPanel, "simmilarPanel");
            simmilarPanel.Name = "simmilarPanel";
            // 
            // simmilarListLayoutPanel
            // 
            resources.ApplyResources(simmilarListLayoutPanel, "simmilarListLayoutPanel");
            simmilarListLayoutPanel.Name = "simmilarListLayoutPanel";
            // 
            // simmilarLabel
            // 
            resources.ApplyResources(simmilarLabel, "simmilarLabel");
            simmilarLabel.Name = "simmilarLabel";
            simmilarLabel.SizeChanged += simmilarLabel_SizeChanged;
            // 
            // additionalDetailLayout
            // 
            resources.ApplyResources(additionalDetailLayout, "additionalDetailLayout");
            detailFormMainLayout.SetColumnSpan(additionalDetailLayout, 2);
            additionalDetailLayout.Controls.Add(substancesText, 1, 10);
            additionalDetailLayout.Controls.Add(overodeText, 0, 10);
            additionalDetailLayout.Controls.Add(compositionText, 1, 8);
            additionalDetailLayout.Controls.Add(dosageText, 0, 8);
            additionalDetailLayout.Controls.Add(interactionsText, 1, 6);
            additionalDetailLayout.Controls.Add(warningsText, 0, 6);
            additionalDetailLayout.Controls.Add(applicabilityText, 1, 4);
            additionalDetailLayout.Controls.Add(sideeffectsText, 0, 4);
            additionalDetailLayout.Controls.Add(indicationsText, 0, 2);
            additionalDetailLayout.Controls.Add(additionalDetailLabel, 0, 0);
            additionalDetailLayout.Controls.Add(pillDocumentIndicationsLabel, 0, 1);
            additionalDetailLayout.Controls.Add(pillDocumentContraindicationsLabel, 1, 1);
            additionalDetailLayout.Controls.Add(pillDocumentSideEffectLabel, 0, 3);
            additionalDetailLayout.Controls.Add(pillDocumentApplicabilityLabel, 1, 3);
            additionalDetailLayout.Controls.Add(pillDocumentWarningsLabel, 0, 5);
            additionalDetailLayout.Controls.Add(pillDocumentInteractionsLabel, 1, 5);
            additionalDetailLayout.Controls.Add(pillDocumentDosageLabel, 0, 7);
            additionalDetailLayout.Controls.Add(pillDocumentCompositionLabel, 1, 7);
            additionalDetailLayout.Controls.Add(pillDocumentOverdoseLabel, 0, 9);
            additionalDetailLayout.Controls.Add(pillDocumentSubstancesLabel, 1, 9);
            additionalDetailLayout.Controls.Add(contraindicationsText, 1, 2);
            additionalDetailLayout.Name = "additionalDetailLayout";
            // 
            // substancesText
            // 
            substancesText.AcceptsReturn = true;
            substancesText.AcceptsTab = true;
            substancesText.BackColor = SystemColors.Control;
            substancesText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(substancesText, "substancesText");
            substancesText.Name = "substancesText";
            substancesText.ReadOnly = true;
            // 
            // overodeText
            // 
            overodeText.AcceptsReturn = true;
            overodeText.AcceptsTab = true;
            overodeText.BackColor = SystemColors.Control;
            overodeText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(overodeText, "overodeText");
            overodeText.Name = "overodeText";
            overodeText.ReadOnly = true;
            // 
            // compositionText
            // 
            compositionText.AcceptsReturn = true;
            compositionText.AcceptsTab = true;
            compositionText.BackColor = SystemColors.Control;
            compositionText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(compositionText, "compositionText");
            compositionText.Name = "compositionText";
            compositionText.ReadOnly = true;
            // 
            // dosageText
            // 
            dosageText.AcceptsReturn = true;
            dosageText.AcceptsTab = true;
            dosageText.BackColor = SystemColors.Control;
            dosageText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(dosageText, "dosageText");
            dosageText.Name = "dosageText";
            dosageText.ReadOnly = true;
            // 
            // interactionsText
            // 
            interactionsText.AcceptsReturn = true;
            interactionsText.AcceptsTab = true;
            interactionsText.BackColor = SystemColors.Control;
            interactionsText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(interactionsText, "interactionsText");
            interactionsText.Name = "interactionsText";
            interactionsText.ReadOnly = true;
            // 
            // warningsText
            // 
            warningsText.AcceptsReturn = true;
            warningsText.AcceptsTab = true;
            warningsText.BackColor = SystemColors.Control;
            warningsText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(warningsText, "warningsText");
            warningsText.Name = "warningsText";
            warningsText.ReadOnly = true;
            // 
            // applicabilityText
            // 
            applicabilityText.AcceptsReturn = true;
            applicabilityText.AcceptsTab = true;
            applicabilityText.BackColor = SystemColors.Control;
            applicabilityText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(applicabilityText, "applicabilityText");
            applicabilityText.Name = "applicabilityText";
            applicabilityText.ReadOnly = true;
            // 
            // sideeffectsText
            // 
            sideeffectsText.AcceptsReturn = true;
            sideeffectsText.AcceptsTab = true;
            sideeffectsText.BackColor = SystemColors.Control;
            sideeffectsText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(sideeffectsText, "sideeffectsText");
            sideeffectsText.Name = "sideeffectsText";
            sideeffectsText.ReadOnly = true;
            // 
            // indicationsText
            // 
            indicationsText.AcceptsReturn = true;
            indicationsText.AcceptsTab = true;
            indicationsText.BackColor = SystemColors.Control;
            indicationsText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(indicationsText, "indicationsText");
            indicationsText.Name = "indicationsText";
            indicationsText.ReadOnly = true;
            // 
            // additionalDetailLabel
            // 
            additionalDetailLayout.SetColumnSpan(additionalDetailLabel, 2);
            resources.ApplyResources(additionalDetailLabel, "additionalDetailLabel");
            additionalDetailLabel.Name = "additionalDetailLabel";
            additionalDetailLabel.SizeChanged += additionalDetailLabel_SizeChanged;
            // 
            // pillDocumentIndicationsLabel
            // 
            resources.ApplyResources(pillDocumentIndicationsLabel, "pillDocumentIndicationsLabel");
            pillDocumentIndicationsLabel.Name = "pillDocumentIndicationsLabel";
            pillDocumentIndicationsLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // pillDocumentContraindicationsLabel
            // 
            resources.ApplyResources(pillDocumentContraindicationsLabel, "pillDocumentContraindicationsLabel");
            pillDocumentContraindicationsLabel.Name = "pillDocumentContraindicationsLabel";
            pillDocumentContraindicationsLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // pillDocumentSideEffectLabel
            // 
            resources.ApplyResources(pillDocumentSideEffectLabel, "pillDocumentSideEffectLabel");
            pillDocumentSideEffectLabel.Name = "pillDocumentSideEffectLabel";
            pillDocumentSideEffectLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // pillDocumentApplicabilityLabel
            // 
            resources.ApplyResources(pillDocumentApplicabilityLabel, "pillDocumentApplicabilityLabel");
            pillDocumentApplicabilityLabel.Name = "pillDocumentApplicabilityLabel";
            pillDocumentApplicabilityLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // pillDocumentWarningsLabel
            // 
            resources.ApplyResources(pillDocumentWarningsLabel, "pillDocumentWarningsLabel");
            pillDocumentWarningsLabel.Name = "pillDocumentWarningsLabel";
            pillDocumentWarningsLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // pillDocumentInteractionsLabel
            // 
            resources.ApplyResources(pillDocumentInteractionsLabel, "pillDocumentInteractionsLabel");
            pillDocumentInteractionsLabel.Name = "pillDocumentInteractionsLabel";
            pillDocumentInteractionsLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // pillDocumentDosageLabel
            // 
            resources.ApplyResources(pillDocumentDosageLabel, "pillDocumentDosageLabel");
            pillDocumentDosageLabel.Name = "pillDocumentDosageLabel";
            pillDocumentDosageLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // pillDocumentCompositionLabel
            // 
            resources.ApplyResources(pillDocumentCompositionLabel, "pillDocumentCompositionLabel");
            pillDocumentCompositionLabel.Name = "pillDocumentCompositionLabel";
            pillDocumentCompositionLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // pillDocumentOverdoseLabel
            // 
            resources.ApplyResources(pillDocumentOverdoseLabel, "pillDocumentOverdoseLabel");
            pillDocumentOverdoseLabel.Name = "pillDocumentOverdoseLabel";
            pillDocumentOverdoseLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // pillDocumentSubstancesLabel
            // 
            resources.ApplyResources(pillDocumentSubstancesLabel, "pillDocumentSubstancesLabel");
            pillDocumentSubstancesLabel.Name = "pillDocumentSubstancesLabel";
            pillDocumentSubstancesLabel.SizeChanged += pillDocumentDetailLabel_SizeChanged;
            // 
            // contraindicationsText
            // 
            contraindicationsText.AcceptsReturn = true;
            contraindicationsText.AcceptsTab = true;
            contraindicationsText.BackColor = SystemColors.Control;
            contraindicationsText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(contraindicationsText, "contraindicationsText");
            contraindicationsText.Name = "contraindicationsText";
            contraindicationsText.ReadOnly = true;
            // 
            // pillDetailLayoutPanel
            // 
            pillDetailLayoutPanel.BackColor = Color.White;
            resources.ApplyResources(pillDetailLayoutPanel, "pillDetailLayoutPanel");
            pillDetailLayoutPanel.Controls.Add(pillSuklText, 1, 11);
            pillDetailLayoutPanel.Controls.Add(pillSklLabel, 0, 11);
            pillDetailLayoutPanel.Controls.Add(pillMedicalSubstancesText, 1, 10);
            pillDetailLayoutPanel.Controls.Add(pillExpirationLabel, 2, 9);
            pillDetailLayoutPanel.Controls.Add(pillUnlimitedRegistartionLabel, 2, 8);
            pillDetailLayoutPanel.Controls.Add(pillRegistartionHolderCountraLabel, 2, 7);
            pillDetailLayoutPanel.Controls.Add(pillRegistrationHolderLabel, 2, 6);
            pillDetailLayoutPanel.Controls.Add(pillRegistrationNumberLabel, 2, 5);
            pillDetailLayoutPanel.Controls.Add(pillATCNameLabel, 2, 4);
            pillDetailLayoutPanel.Controls.Add(pillATCCodeLabel, 2, 3);
            pillDetailLayoutPanel.Controls.Add(pillDispensingLabel, 0, 9);
            pillDetailLayoutPanel.Controls.Add(pillCoverLabel, 0, 8);
            pillDetailLayoutPanel.Controls.Add(pillWayOfUseLabel, 0, 7);
            pillDetailLayoutPanel.Controls.Add(pillPackingLabel, 0, 6);
            pillDetailLayoutPanel.Controls.Add(pillFormLabel, 0, 5);
            pillDetailLayoutPanel.Controls.Add(pillSupplementLabel, 0, 4);
            pillDetailLayoutPanel.Controls.Add(pillPowerLabel, 0, 3);
            pillDetailLayoutPanel.Controls.Add(pillNameLabel, 0, 1);
            pillDetailLayoutPanel.Controls.Add(pillPowerText, 1, 3);
            pillDetailLayoutPanel.Controls.Add(pillSupplementText, 1, 4);
            pillDetailLayoutPanel.Controls.Add(pillFormText, 1, 5);
            pillDetailLayoutPanel.Controls.Add(pillPackingText, 1, 6);
            pillDetailLayoutPanel.Controls.Add(pillWayOfUseText, 1, 7);
            pillDetailLayoutPanel.Controls.Add(pillCoverText, 1, 8);
            pillDetailLayoutPanel.Controls.Add(pillDispensingText, 1, 9);
            pillDetailLayoutPanel.Controls.Add(pillATCCodeText, 3, 3);
            pillDetailLayoutPanel.Controls.Add(pillAtcNameText, 3, 4);
            pillDetailLayoutPanel.Controls.Add(pillRegistrationNumberText, 3, 5);
            pillDetailLayoutPanel.Controls.Add(pillRegistrationHolderText, 3, 6);
            pillDetailLayoutPanel.Controls.Add(pillRegistrationHolderCountryText, 3, 7);
            pillDetailLayoutPanel.Controls.Add(pillUnlimitedRegistrationText, 3, 8);
            pillDetailLayoutPanel.Controls.Add(pillExpirationText, 3, 9);
            pillDetailLayoutPanel.Controls.Add(pillDocumentsLabel, 2, 10);
            pillDetailLayoutPanel.Controls.Add(pillMedicalSubstancesLabel, 0, 10);
            pillDetailLayoutPanel.Controls.Add(openPillDocumentButton, 3, 10);
            pillDetailLayoutPanel.Controls.Add(panel1, 3, 1);
            pillDetailLayoutPanel.Controls.Add(pillAddToListButton, 3, 11);
            pillDetailLayoutPanel.Controls.Add(panel2, 0, 0);
            pillDetailLayoutPanel.Name = "pillDetailLayoutPanel";
            // 
            // pillSuklText
            // 
            resources.ApplyResources(pillSuklText, "pillSuklText");
            pillSuklText.BackColor = Color.LightSkyBlue;
            pillSuklText.Name = "pillSuklText";
            // 
            // pillSklLabel
            // 
            resources.ApplyResources(pillSklLabel, "pillSklLabel");
            pillSklLabel.Name = "pillSklLabel";
            // 
            // pillMedicalSubstancesText
            // 
            resources.ApplyResources(pillMedicalSubstancesText, "pillMedicalSubstancesText");
            pillMedicalSubstancesText.BackColor = Color.LightSkyBlue;
            pillMedicalSubstancesText.Name = "pillMedicalSubstancesText";
            // 
            // pillExpirationLabel
            // 
            resources.ApplyResources(pillExpirationLabel, "pillExpirationLabel");
            pillExpirationLabel.Name = "pillExpirationLabel";
            pillExpirationLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillUnlimitedRegistartionLabel
            // 
            resources.ApplyResources(pillUnlimitedRegistartionLabel, "pillUnlimitedRegistartionLabel");
            pillUnlimitedRegistartionLabel.Name = "pillUnlimitedRegistartionLabel";
            pillUnlimitedRegistartionLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillRegistartionHolderCountraLabel
            // 
            resources.ApplyResources(pillRegistartionHolderCountraLabel, "pillRegistartionHolderCountraLabel");
            pillRegistartionHolderCountraLabel.Name = "pillRegistartionHolderCountraLabel";
            pillRegistartionHolderCountraLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillRegistrationHolderLabel
            // 
            resources.ApplyResources(pillRegistrationHolderLabel, "pillRegistrationHolderLabel");
            pillRegistrationHolderLabel.Name = "pillRegistrationHolderLabel";
            pillRegistrationHolderLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillRegistrationNumberLabel
            // 
            resources.ApplyResources(pillRegistrationNumberLabel, "pillRegistrationNumberLabel");
            pillRegistrationNumberLabel.Name = "pillRegistrationNumberLabel";
            pillRegistrationNumberLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillATCNameLabel
            // 
            resources.ApplyResources(pillATCNameLabel, "pillATCNameLabel");
            pillATCNameLabel.Name = "pillATCNameLabel";
            pillATCNameLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillATCCodeLabel
            // 
            resources.ApplyResources(pillATCCodeLabel, "pillATCCodeLabel");
            pillATCCodeLabel.Name = "pillATCCodeLabel";
            pillATCCodeLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillDispensingLabel
            // 
            resources.ApplyResources(pillDispensingLabel, "pillDispensingLabel");
            pillDispensingLabel.Name = "pillDispensingLabel";
            pillDispensingLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillCoverLabel
            // 
            resources.ApplyResources(pillCoverLabel, "pillCoverLabel");
            pillCoverLabel.Name = "pillCoverLabel";
            pillCoverLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillWayOfUseLabel
            // 
            resources.ApplyResources(pillWayOfUseLabel, "pillWayOfUseLabel");
            pillWayOfUseLabel.Name = "pillWayOfUseLabel";
            pillWayOfUseLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillPackingLabel
            // 
            resources.ApplyResources(pillPackingLabel, "pillPackingLabel");
            pillPackingLabel.Name = "pillPackingLabel";
            pillPackingLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillFormLabel
            // 
            resources.ApplyResources(pillFormLabel, "pillFormLabel");
            pillFormLabel.Name = "pillFormLabel";
            pillFormLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillSupplementLabel
            // 
            resources.ApplyResources(pillSupplementLabel, "pillSupplementLabel");
            pillSupplementLabel.Name = "pillSupplementLabel";
            pillSupplementLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillPowerLabel
            // 
            resources.ApplyResources(pillPowerLabel, "pillPowerLabel");
            pillPowerLabel.Name = "pillPowerLabel";
            pillPowerLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillNameLabel
            // 
            resources.ApplyResources(pillNameLabel, "pillNameLabel");
            pillDetailLayoutPanel.SetColumnSpan(pillNameLabel, 3);
            pillNameLabel.Name = "pillNameLabel";
            pillDetailLayoutPanel.SetRowSpan(pillNameLabel, 2);
            pillNameLabel.SizeChanged += pillNameLabel_SizeChanged;
            // 
            // pillPowerText
            // 
            resources.ApplyResources(pillPowerText, "pillPowerText");
            pillPowerText.BackColor = Color.LightSkyBlue;
            pillPowerText.Name = "pillPowerText";
            // 
            // pillSupplementText
            // 
            resources.ApplyResources(pillSupplementText, "pillSupplementText");
            pillSupplementText.BackColor = Color.LightSkyBlue;
            pillSupplementText.Name = "pillSupplementText";
            // 
            // pillFormText
            // 
            pillFormText.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(pillFormText, "pillFormText");
            pillFormText.Name = "pillFormText";
            // 
            // pillPackingText
            // 
            resources.ApplyResources(pillPackingText, "pillPackingText");
            pillPackingText.BackColor = Color.LightSkyBlue;
            pillPackingText.Name = "pillPackingText";
            // 
            // pillWayOfUseText
            // 
            resources.ApplyResources(pillWayOfUseText, "pillWayOfUseText");
            pillWayOfUseText.BackColor = Color.LightSkyBlue;
            pillWayOfUseText.Name = "pillWayOfUseText";
            // 
            // pillCoverText
            // 
            resources.ApplyResources(pillCoverText, "pillCoverText");
            pillCoverText.BackColor = Color.LightSkyBlue;
            pillCoverText.Name = "pillCoverText";
            // 
            // pillDispensingText
            // 
            resources.ApplyResources(pillDispensingText, "pillDispensingText");
            pillDispensingText.BackColor = Color.LightSkyBlue;
            pillDispensingText.Name = "pillDispensingText";
            // 
            // pillATCCodeText
            // 
            resources.ApplyResources(pillATCCodeText, "pillATCCodeText");
            pillATCCodeText.BackColor = Color.LightSkyBlue;
            pillATCCodeText.Name = "pillATCCodeText";
            // 
            // pillAtcNameText
            // 
            resources.ApplyResources(pillAtcNameText, "pillAtcNameText");
            pillAtcNameText.BackColor = Color.LightSkyBlue;
            pillAtcNameText.Name = "pillAtcNameText";
            // 
            // pillRegistrationNumberText
            // 
            resources.ApplyResources(pillRegistrationNumberText, "pillRegistrationNumberText");
            pillRegistrationNumberText.BackColor = Color.LightSkyBlue;
            pillRegistrationNumberText.Name = "pillRegistrationNumberText";
            // 
            // pillRegistrationHolderText
            // 
            resources.ApplyResources(pillRegistrationHolderText, "pillRegistrationHolderText");
            pillRegistrationHolderText.BackColor = Color.LightSkyBlue;
            pillRegistrationHolderText.Name = "pillRegistrationHolderText";
            // 
            // pillRegistrationHolderCountryText
            // 
            resources.ApplyResources(pillRegistrationHolderCountryText, "pillRegistrationHolderCountryText");
            pillRegistrationHolderCountryText.BackColor = Color.LightSkyBlue;
            pillRegistrationHolderCountryText.Name = "pillRegistrationHolderCountryText";
            // 
            // pillUnlimitedRegistrationText
            // 
            resources.ApplyResources(pillUnlimitedRegistrationText, "pillUnlimitedRegistrationText");
            pillUnlimitedRegistrationText.BackColor = Color.White;
            pillUnlimitedRegistrationText.Name = "pillUnlimitedRegistrationText";
            // 
            // pillExpirationText
            // 
            resources.ApplyResources(pillExpirationText, "pillExpirationText");
            pillExpirationText.BackColor = Color.LightSkyBlue;
            pillExpirationText.Name = "pillExpirationText";
            // 
            // pillDocumentsLabel
            // 
            resources.ApplyResources(pillDocumentsLabel, "pillDocumentsLabel");
            pillDocumentsLabel.Name = "pillDocumentsLabel";
            pillDocumentsLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // pillMedicalSubstancesLabel
            // 
            resources.ApplyResources(pillMedicalSubstancesLabel, "pillMedicalSubstancesLabel");
            pillMedicalSubstancesLabel.Name = "pillMedicalSubstancesLabel";
            pillMedicalSubstancesLabel.SizeChanged += pillDetailsLabel_SizeChanged;
            // 
            // openPillDocumentButton
            // 
            resources.ApplyResources(openPillDocumentButton, "openPillDocumentButton");
            openPillDocumentButton.Cursor = Cursors.Hand;
            openPillDocumentButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            openPillDocumentButton.Depth = 0;
            openPillDocumentButton.HighEmphasis = true;
            openPillDocumentButton.Icon = null;
            openPillDocumentButton.MouseState = MaterialSkin.MouseState.HOVER;
            openPillDocumentButton.Name = "openPillDocumentButton";
            openPillDocumentButton.NoAccentTextColor = Color.Empty;
            openPillDocumentButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            openPillDocumentButton.UseAccentColor = true;
            openPillDocumentButton.UseVisualStyleBackColor = true;
            openPillDocumentButton.Click += openPillDocumentButton_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            pillDetailLayoutPanel.SetRowSpan(panel1, 2);
            // 
            // pillAddToListButton
            // 
            resources.ApplyResources(pillAddToListButton, "pillAddToListButton");
            pillAddToListButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            pillAddToListButton.Depth = 0;
            pillAddToListButton.HighEmphasis = true;
            pillAddToListButton.Icon = null;
            pillAddToListButton.MouseState = MaterialSkin.MouseState.HOVER;
            pillAddToListButton.Name = "pillAddToListButton";
            pillAddToListButton.NoAccentTextColor = Color.Empty;
            pillAddToListButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pillAddToListButton.UseAccentColor = false;
            pillAddToListButton.UseVisualStyleBackColor = true;
            pillAddToListButton.Click += pillAddToListButton_Click;
            // 
            // panel2
            // 
            pillDetailLayoutPanel.SetColumnSpan(panel2, 4);
            panel2.Controls.Add(pillsDetailWarningLabel);
            panel2.Controls.Add(goBackToSearchButton);
            panel2.Controls.Add(pillDetailsHelpButton);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // pillsDetailWarningLabel
            // 
            resources.ApplyResources(pillsDetailWarningLabel, "pillsDetailWarningLabel");
            pillsDetailWarningLabel.Name = "pillsDetailWarningLabel";
            // 
            // goBackToSearchButton
            // 
            resources.ApplyResources(goBackToSearchButton, "goBackToSearchButton");
            goBackToSearchButton.Cursor = Cursors.Hand;
            goBackToSearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            goBackToSearchButton.Depth = 0;
            goBackToSearchButton.HighEmphasis = true;
            goBackToSearchButton.Icon = Properties.Resources.whiteBackArrow;
            goBackToSearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            goBackToSearchButton.Name = "goBackToSearchButton";
            goBackToSearchButton.NoAccentTextColor = Color.Empty;
            goBackToSearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            goBackToSearchButton.UseAccentColor = false;
            goBackToSearchButton.UseVisualStyleBackColor = true;
            goBackToSearchButton.Click += goBackToSearchButton_Click;
            // 
            // pillDetailsHelpButton
            // 
            resources.ApplyResources(pillDetailsHelpButton, "pillDetailsHelpButton");
            pillDetailsHelpButton.Cursor = Cursors.Hand;
            pillDetailsHelpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            pillDetailsHelpButton.Depth = 0;
            pillDetailsHelpButton.HighEmphasis = true;
            pillDetailsHelpButton.Icon = null;
            pillDetailsHelpButton.MouseState = MaterialSkin.MouseState.HOVER;
            pillDetailsHelpButton.Name = "pillDetailsHelpButton";
            pillDetailsHelpButton.NoAccentTextColor = Color.Empty;
            pillDetailsHelpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pillDetailsHelpButton.UseAccentColor = false;
            pillDetailsHelpButton.UseVisualStyleBackColor = true;
            pillDetailsHelpButton.Click += pillDetailsHelpButton_Click;
            // 
            // PillsDetailForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(detailFormMainLayout);
            Name = "PillsDetailForm";
            detailFormMainLayout.ResumeLayout(false);
            simmilarPanel.ResumeLayout(false);
            additionalDetailLayout.ResumeLayout(false);
            additionalDetailLayout.PerformLayout();
            pillDetailLayoutPanel.ResumeLayout(false);
            pillDetailLayoutPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip pillDetailTooltip;
        private TableLayoutPanel detailFormMainLayout;
        private TableLayoutPanel pillDetailLayoutPanel;
        private Label pillExpirationLabel;
        private Label pillUnlimitedRegistartionLabel;
        private Label pillRegistartionHolderCountraLabel;
        private Label pillRegistrationHolderLabel;
        private Label pillRegistrationNumberLabel;
        private Label pillATCNameLabel;
        private Label pillATCCodeLabel;
        private Label pillDispensingLabel;
        private Label pillCoverLabel;
        private Label pillWayOfUseLabel;
        private Label pillPackingLabel;
        private Label pillFormLabel;
        private Label pillSupplementLabel;
        private MaterialSkin.Controls.MaterialButton goBackToSearchButton;
        private MaterialSkin.Controls.MaterialButton pillDetailsHelpButton;
        private Label pillPowerLabel;
        private Label pillNameLabel;
        private Label pillPowerText;
        private Label pillSupplementText;
        private Label pillFormText;
        private Label pillPackingText;
        private Label pillWayOfUseText;
        private Label pillCoverText;
        private Label pillDispensingText;
        private Label pillATCCodeText;
        private Label pillAtcNameText;
        private Label pillRegistrationNumberText;
        private Label pillRegistrationHolderText;
        private Label pillRegistrationHolderCountryText;
        private Label pillUnlimitedRegistrationText;
        private Label pillExpirationText;
        private Panel simmilarPanel;
        private FlowLayoutPanel simmilarListLayoutPanel;
        private Label simmilarLabel;
        private TableLayoutPanel additionalDetailLayout;
        private Label additionalDetailLabel;
        private Label pillDocumentIndicationsLabel;
        private Label pillDocumentContraindicationsLabel;
        private Label pillDocumentSideEffectLabel;
        private Label pillDocumentApplicabilityLabel;
        private Label pillDocumentWarningsLabel;
        private Label pillDocumentInteractionsLabel;
        private Label pillDocumentDosageLabel;
        private Label pillDocumentCompositionLabel;
        private Label pillDocumentOverdoseLabel;
        private Label pillDocumentSubstancesLabel;
        private TextBox substancesText;
        private TextBox overodeText;
        private TextBox compositionText;
        private TextBox dosageText;
        private TextBox interactionsText;
        private TextBox warningsText;
        private TextBox applicabilityText;
        private TextBox sideeffectsText;
        private TextBox indicationsText;
        private TextBox contraindicationsText;
        private Label pillDocumentsLabel;
        private Label pillMedicalSubstancesText;
        private Label pillMedicalSubstancesLabel;
        private MaterialSkin.Controls.MaterialButton openPillDocumentButton;
        private Panel panel1;
        private Label pillSuklText;
        private Label pillSklLabel;
        private MaterialSkin.Controls.MaterialButton pillAddToListButton;
        private Panel panel2;
        private Label pillsDetailWarningLabel;
    }
}