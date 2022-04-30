interface CoinInterface{
    name?: string;
    abrevation: string;
    valueInEUR: number;
    valueInUSD: number;
}

interface CoinFuncInterface{
    (valueEUR: number, valueUSD: number): boolean;
    //(name: string): void;
}

function createCoin(template: CoinInterface): {name: string, abv: string, valueEUR: number, valueUSD: number}{
    return {
        abv: template.abrevation,
        name: template.name || "default name",
        valueEUR: template.valueInEUR,
        valueUSD: template.valueInUSD
    }
}

let newCoin = createCoin({name: "Bitcoin", abrevation: "BTC", valueInEUR: 40000, valueInUSD: 45000} as CoinInterface);
console.log(newCoin.name)

let checkValues : CoinFuncInterface;

checkValues = function (no1, no2){
    return (no1 > 1) && (no2 > 1.2);
}

console.log(checkValues(3,1.3));
console.log(1,1.2);

