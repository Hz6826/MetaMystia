using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001DF RID: 479
	public class NS_MGuest_MVT_Spawn_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C35 RID: 15413 RVA: 0x0016B52C File Offset: 0x0016972C
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_MVT_Spawn_Behaviour()
		{
			Il2CppClassPointerStore<NS_MGuest_MVT_Spawn_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_MVT_Spawn_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn_Behaviour>.NativeClassPtr);
			NS_MGuest_MVT_Spawn_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn_Behaviour>.NativeClassPtr, "label");
			NS_MGuest_MVT_Spawn_Behaviour.NativeFieldInfoPtr_spawnInA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn_Behaviour>.NativeClassPtr, "spawnInA");
			NS_MGuest_MVT_Spawn_Behaviour.NativeFieldInfoPtr_specialGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn_Behaviour>.NativeClassPtr, "specialGuestId");
			NS_MGuest_MVT_Spawn_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn_Behaviour>.NativeClassPtr, 100674475);
			NS_MGuest_MVT_Spawn_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn_Behaviour>.NativeClassPtr, 100674476);
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x0016B5C0 File Offset: 0x001697C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136701, XrefRangeEnd = 136705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_MVT_Spawn_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x0016B5FC File Offset: 0x001697FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_MVT_Spawn_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_MVT_Spawn_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_MVT_Spawn_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x00021CAF File Offset: 0x0001FEAF
		public NS_MGuest_MVT_Spawn_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x0016B638 File Offset: 0x00169838
		// (set) Token: 0x06003C3A RID: 15418 RVA: 0x00021CB8 File Offset: 0x0001FEB8
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x0016B660 File Offset: 0x00169860
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x00021CD7 File Offset: 0x0001FED7
		public unsafe bool spawnInA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn_Behaviour.NativeFieldInfoPtr_spawnInA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn_Behaviour.NativeFieldInfoPtr_spawnInA)) = value;
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x0016B688 File Offset: 0x00169888
		// (set) Token: 0x06003C3E RID: 15422 RVA: 0x00021CF2 File Offset: 0x0001FEF2
		public unsafe int specialGuestId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn_Behaviour.NativeFieldInfoPtr_specialGuestId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_Spawn_Behaviour.NativeFieldInfoPtr_specialGuestId)) = value;
			}
		}

		// Token: 0x0400286C RID: 10348
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x0400286D RID: 10349
		private static readonly IntPtr NativeFieldInfoPtr_spawnInA;

		// Token: 0x0400286E RID: 10350
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestId;

		// Token: 0x0400286F RID: 10351
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04002870 RID: 10352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
