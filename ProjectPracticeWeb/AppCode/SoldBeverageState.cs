﻿using System;
using ProjectPracticeWeb.Models;

namespace ProjectPracticeWeb.AppCode
{
	public class SoldBeverageState : IState
	{
		public bool Dispense(IVendingMachine vm, Beverage bev)
		{
			if (!vm.ReleaseBeverage(bev)) return false;
			if (vm.HasMoneyInserted())
			{
				vm.State = new InsertedUserCoinsState();
			}
			else
			{
				vm.State = new NoUserCoinsState();
			}
			return true;
		}

		public bool InsertCoin(int nominal, IVendingMachine vm)
		{
			return false;
		}

		public bool ReturnCoins(IVendingMachine vm)
		{
			return false;
		}

		public bool TurnCrank(IVendingMachine vm)
		{
			return false;
		}

		public bool TurnCrank(IVendingMachine vm, Beverage bev)
		{
			return false;
		}
	}
}