using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer_sc
{
    public int numberOfNeurons;
    public List<Neuron> neurons = new List<Neuron>();

    public Layer_sc(int numberOfNeurons, int numberOfInputs)
    {
        this.numberOfNeurons = numberOfNeurons;
        for (int i = 0; i < numberOfNeurons; i++)
        {
            neurons.Add(new Neuron(numberOfInputs));
        }
    }
}

