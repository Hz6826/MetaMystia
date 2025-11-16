using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001DE RID: 478
	public class NS_Set_DoSpawnNGuest_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C2F RID: 15407 RVA: 0x0016B420 File Offset: 0x00169620
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Set_DoSpawnNGuest_Behaviour()
		{
			Il2CppClassPointerStore<NS_Set_DoSpawnNGuest_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Set_DoSpawnNGuest_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest_Behaviour>.NativeClassPtr);
			NS_Set_DoSpawnNGuest_Behaviour.NativeFieldInfoPtr_shouldSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest_Behaviour>.NativeClassPtr, "shouldSpawn");
			NS_Set_DoSpawnNGuest_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest_Behaviour>.NativeClassPtr, 100674473);
			NS_Set_DoSpawnNGuest_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest_Behaviour>.NativeClassPtr, 100674474);
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0016B48C File Offset: 0x0016968C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136696, XrefRangeEnd = 136701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Set_DoSpawnNGuest_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x0016B4C8 File Offset: 0x001696C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Set_DoSpawnNGuest_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Set_DoSpawnNGuest_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Set_DoSpawnNGuest_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x00021C8B File Offset: 0x0001FE8B
		public NS_Set_DoSpawnNGuest_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06003C33 RID: 15411 RVA: 0x0016B504 File Offset: 0x00169704
		// (set) Token: 0x06003C34 RID: 15412 RVA: 0x00021C94 File Offset: 0x0001FE94
		public unsafe bool shouldSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoSpawnNGuest_Behaviour.NativeFieldInfoPtr_shouldSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoSpawnNGuest_Behaviour.NativeFieldInfoPtr_shouldSpawn)) = value;
			}
		}

		// Token: 0x04002869 RID: 10345
		private static readonly IntPtr NativeFieldInfoPtr_shouldSpawn;

		// Token: 0x0400286A RID: 10346
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x0400286B RID: 10347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
