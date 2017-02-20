using UnityEngine;
using System.Collections;

namespace Commands {
	
	public class JumpCommand : ICommand{

		public void Execute(Actions pActions){
			
			pActions.Jump ();

		}

	}

	public class AttackCommand : ICommand{

		public void Execute(Actions pActions){

			pActions.Attack ();

		}

	}

	public class MoveLeftCommand : ICommand{

		public void Execute(Actions pActions){

			pActions.Move (-1);

		}

	}

	public class MoveRightCommand : ICommand{

		public void Execute(Actions pActions){

			pActions.Move (1);

		}

	}

}
