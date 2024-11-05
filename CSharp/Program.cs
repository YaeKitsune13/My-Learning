
string funcCheking(string Text){
    Console.WriteLine(Text);
    return Text;
}

var Chenking = new Dictionary<string,object>(){
    {"Key1",funcCheking("Текст1")}
};

Chenking['Key1'];