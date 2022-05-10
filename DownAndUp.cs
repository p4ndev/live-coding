
//=====================================================
//======================= Data ========================
//=====================================================

var inp = new int[3]{ 1, 2, 3 };
var res = DownAndUp(inp);

//=====================================================
//====================== Statements ===================
//=====================================================

Func<int[], string> Combine = (int[] source) => {
    string dbg = string.Empty;
    foreach(var n in source) dbg += n + " ";
    return dbg;
};

Action<int[]?> CombineAndPrint = source => {
    if(source is null) return;
    string all = Combine(source!);
    Console.WriteLine(all);
};

static int[]? DownAndUp(int[] input, int rounds = 2){
    if(input.Length <= 0) return null;
    List<int> output = new();
    while(rounds > 0){
        Array.Reverse(input);
        output.AddRange(input);
        rounds--;
    }
    return output.ToArray<int>();
}

//=====================================================
//======================= Output ======================
//=====================================================

CombineAndPrint(res);
CombineAndPrint(inp);
