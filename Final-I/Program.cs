
int[]? res = Check(new int[5]{1,2,3,4,3});

if(res != null){
    Console.WriteLine("Wrong: " + res[0]);
    Console.WriteLine("Should be: " + res[1]);
} else
    Console.WriteLine("Right numeral orders...");

// ============================================================
// ============================================================
// ============================================================

res = Check(new int[3]{1,2,2});

if(res != null){
    Console.WriteLine("Wrong: " + res[0]);
    Console.WriteLine("Should be: " + res[1]);
} else
    Console.WriteLine("Right numeral orders...");

// ============================================================
// ============================================================
// ============================================================

res = Check(new int[8]{1,2,3,4,5,6,7,8});

if(res != null){
    Console.WriteLine("Wrong: " + res[0]);
    Console.WriteLine("Should be: " + res[1]);
}else
    Console.WriteLine("Right numeral orders...");

// ============================================================
// ============================================================
// ============================================================

static int[]? Check(int[] input){
    int[] output = new int[2]{ 0, 0 };
    for(int i = 0; i < input.Length; i++){
        if(input[i] != (i+1)){
            output[0] = input[i];
            output[1] = (i+1);
        }
    }
    if(output[0] == 0 && output[1] == 0) return null;
    return output;
}
