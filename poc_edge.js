var edge = require('edge');

var builder = {
    createClasses: function (quantity, model) {
        var classCuilderProxy = edge.func({
            assemblyFile: './dll/Test.dll',
            typeName: 'Test.ClassBuilder',
            methodName: 'CreateAsync'
        });

        classCuilderProxy({ quantity: quantity, model: model }, function (error, result) {
            if (error) throw error;

            console.log(result);
        });
    }
};

builder.createClasses(5, { title: 'Teste de título', description: "Teste de descrição" });