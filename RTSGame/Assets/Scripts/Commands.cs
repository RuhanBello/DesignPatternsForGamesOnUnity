using UnityEngine;
using System.Collections;

namespace Commands{

	public class MoveCommand : ICommand {

		public void Execute(GameObject actor){

			UnitActions.instance.Move (actor);

		}

	}

	public class AttackCommand : ICommand {
		
		public void Execute(GameObject actor){

			UnitActions.instance.Attack (actor);

		}

	}

}