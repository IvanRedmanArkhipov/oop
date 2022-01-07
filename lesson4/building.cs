using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    internal class building
    {
        private int _id;
        private int _height;
        private int _floorsNum;
        private int _flatsNum;
        private int _podjezdNum;

        public int Id
        {
            get { return _id; }
        }

        public int Height
        {
            get { return _height; }
        }

        public int FloorsNum
        {
            get { return _floorsNum; }
        }

        public int FlatsNum
        {
            get { return _flatsNum; }
        }

        public int PodjezdNum
        {
            get { return _podjezdNum;}
        }

        public building(int id, int height, int floorsNum, int flatsNum, int podjezdNum)
        {
            _id = id;
            _height = height;
            _floorsNum = floorsNum;
            _flatsNum = flatsNum;
            _podjezdNum = podjezdNum;
        }

        public int floorHeight()
        {
            return (_height / _floorsNum);
        }

        public int podjezdFlatsNum()
        {
            return (_flatsNum / _podjezdNum);
        }

        public int floorFlatsNum()
        {
            return (_flatsNum / _floorsNum);
        }
    }
}
