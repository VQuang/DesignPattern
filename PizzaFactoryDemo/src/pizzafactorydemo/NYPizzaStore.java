/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pizzafactorydemo;

/**
 *
 * @author VinhQuang
 */
public class NYPizzaStore extends PizzaStore
{

    @Override
    public Pizza createPizza(String item) {
        if(item.equals("cheese"))
            return new NYStyleCheesePizza();
        else if(item.equals("veggie"))
            return new NYStyleVeggiePizza();
        else return null;
    }
    
    
    
}
