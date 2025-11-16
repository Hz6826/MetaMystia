using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001DC RID: 476
	public class NS_SetPlayerToDefaultSpawn_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C25 RID: 15397 RVA: 0x0016B244 File Offset: 0x00169444
		// Note: this type is marked as 'beforefieldinit'.
		static NS_SetPlayerToDefaultSpawn_Behaviour()
		{
			Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_SetPlayerToDefaultSpawn_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn_Behaviour>.NativeClassPtr);
			NS_SetPlayerToDefaultSpawn_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn_Behaviour>.NativeClassPtr, 100674469);
			NS_SetPlayerToDefaultSpawn_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn_Behaviour>.NativeClassPtr, 100674470);
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x0016B29C File Offset: 0x0016949C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136686, XrefRangeEnd = 136691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_SetPlayerToDefaultSpawn_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x0016B2D8 File Offset: 0x001694D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_SetPlayerToDefaultSpawn_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_SetPlayerToDefaultSpawn_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_SetPlayerToDefaultSpawn_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00021C5E File Offset: 0x0001FE5E
		public NS_SetPlayerToDefaultSpawn_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
