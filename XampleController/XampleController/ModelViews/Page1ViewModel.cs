using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XampleController.Models;

namespace XampleController.ModelViews
{
    public class Page1ViewModel
    {


        public Page1ViewModel()
        {
            CreatePipeLists();
        }
        public ObservableCollection<Pipe> PipeList { get; set; }

        //private string _material;

        //public string Material
        //{
        //    get { return _material; }
        //    set { _material = value; }
        //}
        //private string _pipeType;

        //public string PipeType
        //{
        //    get { return _pipeType; }
        //    set { _pipeType = value; }
        //}

        //private string _formerCode;

        //public string FormerCode
        //{
        //    get { return _formerCode; }
        //    set { _formerCode = value; }
        //}

        //private string _heat;

        //public string Heat
        //{
        //    get { return _heat; }
        //    set { _heat = value; }
        //}

        //private string _runnigLength;

        //public string RunnigLength
        //{
        //    get { return _runnigLength; }
        //    set { _runnigLength = value; }
        //}




        private void CreatePipeLists()
        {
            PipeList = new ObservableCollection<Pipe>
            {
                new Pipe() { Material = "3.7", PipeType = "TSH-Blue", FormerCode = "10095", Heat = "2002121", RunningLength = "13.445" },
                new Pipe() { Material = "3.7", PipeType = "TSH-Blue", FormerCode = "10095", Heat = "2002121", RunningLength = "13.445" },
                new Pipe() { Material = "3.7", PipeType = "TSH-Blue", FormerCode = "10095", Heat = "2002121", RunningLength = "13.445" },
                new Pipe() { Material = "3.7", PipeType = "TSH-Blue", FormerCode = "10095", Heat = "2002121", RunningLength = "13.445" }
            };
        }



    }
}
