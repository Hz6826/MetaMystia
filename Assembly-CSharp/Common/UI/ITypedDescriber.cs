using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Common.UI
{
	// Token: 0x0200035E RID: 862
	public class ITypedDescriber<T> : Il2CppObjectBase
	{
		// Token: 0x060065ED RID: 26093 RVA: 0x001F2D50 File Offset: 0x001F0F50
		// Note: this type is marked as 'beforefieldinit'.
		static ITypedDescriber()
		{
			Il2CppClassPointerStore<ITypedDescriber<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "ITypedDescriber`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			ITypedDescriber<T>.NativeMethodInfoPtr_Describe_Public_Abstract_Virtual_New_Void_T_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITypedDescriber<T>>.NativeClassPtr, 100684655);
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x001F2DC8 File Offset: 0x001F0FC8
		[CallerCount(0)]
		public unsafe virtual void Describe(T data, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = data;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref data;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITypedDescriber<T>.NativeMethodInfoPtr_Describe_Public_Abstract_Virtual_New_Void_T_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x00037102 File Offset: 0x00035302
		public ITypedDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400439E RID: 17310
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Abstract_Virtual_New_Void_T_CancellationToken_0;
	}
}
