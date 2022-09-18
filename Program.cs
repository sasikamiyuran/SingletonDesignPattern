using Implementation;


Parallel.Invoke(() =>
{
    var instance1 = Logger.Instance;
},
() =>
{
    var instance1 = Logger.Instance;
},
() =>
{
    var instance1 = Logger.Instance;
},
() =>
{
    var instance1 = Logger.Instance;
});


// var instance1 = Logger.Instance;
// var instance2 = Logger.Instance;
// var instance3 = Logger.Instance;

