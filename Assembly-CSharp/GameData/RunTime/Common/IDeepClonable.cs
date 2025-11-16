using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace GameData.RunTime.Common
{
	// Token: 0x02000229 RID: 553
	public class IDeepClonable<T> : Il2CppObjectBase
	{
		// Token: 0x060041BB RID: 16827 RVA: 0x0017FB1C File Offset: 0x0017DD1C
		// Note: this type is marked as 'beforefieldinit'.
		static IDeepClonable()
		{
			Il2CppClassPointerStore<IDeepClonable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common", "IDeepClonable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IDeepClonable<T>.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeepClonable<T>>.NativeClassPtr, 100675768);
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x0017FB94 File Offset: 0x0017DD94
		[CallerCount(0)]
		public unsafe virtual T Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeepClonable<T>.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x00023888 File Offset: 0x00021A88
		public IDeepClonable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002C55 RID: 11349
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_T_0;
	}
}
