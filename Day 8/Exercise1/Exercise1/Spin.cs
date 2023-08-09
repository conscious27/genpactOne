using System;

namespace Exercise1
{
    public class Spin
    {
        int energy;
        double wProb;
        int no_of_spin;
        public Spin()
        {
            no_of_spin = 5;
        }

        public int Energy { get { return energy; } }
        public double WProb { get {  return wProb; } }
        public int NoOfSpin { set { no_of_spin = value; } get { return no_of_spin; } }

        public void ZeroSpin()
        {
            energy = 1;
            wProb = 100;
        }
        public void FirstSpin()
        {
            energy += 1;
            wProb += 10;
        }

        public void SecondSpin()
        {
            energy += 2;
            wProb += 20;

        }
        public void ThirdSpin()
        {
            energy -= 3;
            wProb -= 30;

        }

        public void FourthSpin()
        {
            energy += 1;
            wProb += 40;

        }

        public void FifthSpin()
        {
            energy -= 5;
            wProb -= 50;

        }

        public void SixthSpin()
        {
            energy -= 1;
            wProb -= 60;

        }

        public void SeventhSpin()
        {
            energy += 1;
            wProb += 70;
        }

        public void EighthSpin()
        {
            energy -= 2;
            wProb -= 20;

        }

        public void NinthSpin()
        {
            energy -= 3;
            wProb -= 30;

        }

        public void TenthSpin()
        {
            energy += 10;
            wProb += 100;

        }

        public void WrongSpin()
        {
            energy -= 10;
            wProb -= 100;
        }

    }
}
