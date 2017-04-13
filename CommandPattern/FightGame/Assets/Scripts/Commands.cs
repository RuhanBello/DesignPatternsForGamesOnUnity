using UnityEngine;
using System.Collections;

namespace Commands {
	
	public class JumpCommand : ICommand{

		public void Execute(){
			
			Actions.instance.Jump ();

		}

	}

	public class AttackCommand : ICommand{

		public void Execute(){

			Actions.instance.Attack ();

		}

	}

	public class MoveLeftCommand : ICommand{

		public void Execute(){

			Actions.instance.Move (-1);

		}

	}

	public class MoveRightCommand : ICommand{

		public void Execute(){

			Actions.instance.Move (1);

		}

	}

}
