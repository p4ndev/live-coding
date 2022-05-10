
Check(new int[6]{1,2,2,2,3,3});

Check(new int[5]{1,2,2,3,4});

Check(new int[3]{1,2,3});

static void Check(int[] arr){

    int res = -1, occ = -1;
    Dictionary<int, int> dic = new();

    foreach(var ite in arr){
        if(dic.ContainsKey(ite))
            dic[ite]++;
        else
            dic.Add(ite, 1);
    }

    foreach(var ite in dic){
        if(ite.Key > res && ite.Value > occ){
            res = ite.Key;
            occ = ite.Value;
        }else
            break;
    }

    Console.WriteLine("[{0},{1}]", res, occ);
    
}
