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
public abstract class PizzaStore 
{
    public abstract Pizza createPizza(String item);
    public Pizza orderPizza(String type)
    {
        Pizza pizza = createPizza(type);
        pizza.prepare();
        pizza.bake();
        pizza.cut();
        pizza.box();
        return pizza;
    }
}
