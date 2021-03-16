using Common.Collections;
using ObservingStudy.Controllers;
using ObservingStudy.Editors;
using ObservingStudy.Interfaces;
using ObservingStudy.Models;
using ObservingStudy.Selectors;
using ObservingStudy.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObservingStudy {

    static class Program {

        static InfoList infoList = new InfoList() {
            Header = "Правителі Київської Русі",
            List = new List<string>() { "Ольга", "Святослав", "Володимир" }
        };

        static FManager fManaging;
        static TextView fTextView;
        static DrawingView drawingView;
        static FEditor fEditor;
        static FListSelector fListSelector;
        static FRadioSelector fRadioSelector;
        static MessageLog messageLog;

        static EditingController editingController;

        static void CreateDependencies() {
            messageLog = new MessageLog();
            fTextView = new TextView(infoList);
            drawingView = new DrawingView(infoList);
            editingController = new EditingController(infoList.List);
            editingController.Changed += fTextView.UpdateInfo;
            fEditor = new FEditor(editingController.ObservableCollection) {
                Header = infoList.Header
            };
            fListSelector = new FListSelector(editingController.ObservableCollection) {
                Header = infoList.Header
            };
            fRadioSelector = new FRadioSelector(editingController.ObservableCollection) {
                Header = infoList.Header
            };
            //fManaging = new FManager(fTextView, fEditor, fListSelector) {
            fManaging = new FManager(drawingView, fEditor, fRadioSelector, messageLog) {
                Title = "RusRulers",
                Header = infoList.Header
            };
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CreateDependencies();

            Application.Run(fManaging);
        }
    }
}
