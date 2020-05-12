using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2-1
/// <summary>
/// DVD会員管理クラス
/// </summary>

class DVDMember
{
    //会員ID管理用変数
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
        Console.WriteLine(this._ID);
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
