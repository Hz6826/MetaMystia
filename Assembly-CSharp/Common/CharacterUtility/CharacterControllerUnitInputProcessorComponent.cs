using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02000456 RID: 1110
	public class CharacterControllerUnitInputProcessorComponent : CharacterControllerUnitComponent
	{
		// Token: 0x06007A9E RID: 31390 RVA: 0x00235444 File Offset: 0x00233644
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterControllerUnitInputProcessorComponent()
		{
			Il2CppClassPointerStore<CharacterControllerUnitInputProcessorComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "CharacterControllerUnitInputProcessorComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterControllerUnitInputProcessorComponent>.NativeClassPtr);
			CharacterControllerUnitInputProcessorComponent.NativeMethodInfoPtr_OnInputPassed_Public_Abstract_Virtual_New_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnitInputProcessorComponent>.NativeClassPtr, 100687879);
			CharacterControllerUnitInputProcessorComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnitInputProcessorComponent>.NativeClassPtr, 100687880);
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x0023549C File Offset: 0x0023369C
		[CallerCount(0)]
		public unsafe virtual Vector2 OnInputPassed(Vector2 input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref input;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterControllerUnitInputProcessorComponent.NativeMethodInfoPtr_OnInputPassed_Public_Abstract_Virtual_New_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x002354F0 File Offset: 0x002336F0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterControllerUnitInputProcessorComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterControllerUnitInputProcessorComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnitInputProcessorComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x000422D5 File Offset: 0x000404D5
		public CharacterControllerUnitInputProcessorComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040050AD RID: 20653
		private static readonly IntPtr NativeMethodInfoPtr_OnInputPassed_Public_Abstract_Virtual_New_Vector2_Vector2_0;

		// Token: 0x040050AE RID: 20654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
