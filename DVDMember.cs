using System;
using System.Collections.Generic;
using System.Text;

namespace List5_1
{
    /// <summary>
    /// DVD会員管理クラス
    /// </summary>
 
    class DVDMember
    {
        //会員ID管理用変数 (フィールド)
        private string _id = string.Empty;

        //会員番号用プロパティ
        public string ID
        {
            get
            {
                return this._id;
            }

            set
            {
                this._id = value;
            }
        }

        public void GetID()
        {
            Console.WriteLine(this._id);
        }
        static void Main(string[] args)
        {
            //インスタンス生成
            DVDMember member = new DVDMember();

            member.ID = "000-00001";

            string strID = member.GetID();

            Console.WriteLine(strID);
        }
    }
}
