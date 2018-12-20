using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storm.Model.DataBase
{
    class CardDataDb
    {
        public static CardDataDb Default { get; } = new CardDataDb();

        private readonly List<DataInfo> dataInfos = new List<DataInfo>();
        public IReadOnlyList<DataInfo> cardDataInfos;

        /*呼ばれると、publicなリストにprivateのリストがはいる*/
        public CardDataDb()
        {
            cardDataInfos = dataInfos.AsReadOnly();

        }

        public void Add(DataInfo dataInfo)
        {
            for(int i=0; i < dataInfo.Rarety;i++)
            {
                dataInfos.Add(dataInfo);
            }

            AddChaged?.Invoke(this,EventArgs.Empty);

        }

        public void ToDraw()
        {
            



        }

        public event EventHandler AddChaged;




    }
}
