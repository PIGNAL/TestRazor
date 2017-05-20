var Persona=function(nombre){
	this.Nombre=nombre;
  this.Hablar=function(){
  	console.log('Hola mi nombre es: '+this.Nombre);
  };
};
var p1=new Persona('Jorge');
console.log(p1.Nombre);
console.log(p1.Hablar());

var p2={
	Nombre:'Jonathan'
};
console.log(p2)
var Persona2=function(){
	var nombre='Jonathan';
	this.Apellido='Ballatore';
	this.Direccion='Famaillá';
};
var p3=new Persona2();

console.log(p3);
var Personas=[
	{Nombre:'Jonathan', Apellido:'Ballatore', Edad:23},
	{Nombre:'Jorge',Apellido:'Ballatore', Edad:51},
	{Nombre:'Joaquin',Apellido:'Martinez', Edad:25}
];
console.log(Personas);
var sal = function(comportamiento){
	num1=1
	num2=14
	suma=num1+num2;
	comportamiento(suma);
}
var fun2=function(resultado){
	console.log(resultado);
	var otraFuncion=function(){
		console.log('Se ejecuto otra funcion');
	}
	return otraFuncion;
}
sal(fun2);

var filtrado = Personas.filter(function(persona){
	return (persona.Apellido=='Ballatore');
});
console.log(filtrado);
var funParametro=function(persona){
	if((persona.Nombre=='Jorge')&&(persona.Apellido=='Ballatore')){
		return true;
	}
	else
		return false;
}
var NuestraFilter=function(lista,funParametro){
	var resultado=[];
	for(var i=0;i<lista.length;i++){
			var resFunParametro=funParametro(lista[i])
			if(resFunParametro==true){
				resultado.push(lista[i]);
			}
	}
	return resultado;
}
console.log(NuestraFilter(Personas,funParametro))

var filtrado2=Personas.filter(x => x.Nombre == 'Jorge' && x.Apellido=='Ballatore');
console.log(filtrado2);

var resultado2=Personas.reduce(function(p,sum){
	console.log(sum);
	console.log(p);
	return sum+=p.Edad;
}, 0);
var funParametro2=function(valorInicial,persona){
	return valorInicial + persona.Edad;
}
var nuestraReduce=function(lista,funParametro2){
	var resultado=0;
	for(var i=0;i<lista.length;i++){
		resultado=funParametro2(resultado,lista[i])
	}
	return resultado
}
console.log(nuestraReduce(Personas,funParametro2));
var resultado3=Personas.reduce((sum,p)=>sum +=p.Edad,0);
console.log(resultado3);