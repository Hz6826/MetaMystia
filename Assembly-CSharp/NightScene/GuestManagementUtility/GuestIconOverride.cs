using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020001A6 RID: 422
	public sealed class GuestIconOverride : ValueType
	{
		// Token: 0x06002F71 RID: 12145 RVA: 0x0013CD7C File Offset: 0x0013AF7C
		// Note: this type is marked as 'beforefieldinit'.
		static GuestIconOverride()
		{
			Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.GuestManagementUtility", "GuestIconOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr);
			GuestIconOverride.NativeFieldInfoPtr_GuestGroupController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr, "GuestGroupController");
			GuestIconOverride.NativeFieldInfoPtr_IconInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr, "IconInstances");
			GuestIconOverride.NativeFieldInfoPtr_GuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr, "GuestState");
			GuestIconOverride.NativeFieldInfoPtr_LifeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr, "LifeSpan");
			GuestIconOverride.NativeFieldInfoPtr_AudioPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr, "AudioPlayed");
			GuestIconOverride.NativeMethodInfoPtr__ctor_Public_Void_GuestGroupController_Il2CppReferenceArray_1_GameObject_GuestState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr, 100671642);
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x0013CE24 File Offset: 0x0013B024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105412, XrefRangeEnd = 105414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestIconOverride(GuestGroupController guestGroupController, Il2CppReferenceArray<GameObject> iconInstances, GuestState guestState, float lifeSpan) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iconInstances);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guestState;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifeSpan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconOverride.NativeMethodInfoPtr__ctor_Public_Void_GuestGroupController_Il2CppReferenceArray_1_GameObject_GuestState_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x0001B314 File Offset: 0x00019514
		public GuestIconOverride(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x0001B31D File Offset: 0x0001951D
		public GuestIconOverride() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestIconOverride>.NativeClassPtr))
		{
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x0013CEA4 File Offset: 0x0013B0A4
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x0001B32F File Offset: 0x0001952F
		public unsafe GuestGroupController GuestGroupController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_GuestGroupController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_GuestGroupController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x0013CED4 File Offset: 0x0013B0D4
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x0001B34E File Offset: 0x0001954E
		public unsafe Il2CppReferenceArray<GameObject> IconInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_IconInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_IconInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x0013CF04 File Offset: 0x0013B104
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x0001B36D File Offset: 0x0001956D
		public unsafe GuestState GuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_GuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_GuestState)) = value;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06002F7B RID: 12155 RVA: 0x0013CF2C File Offset: 0x0013B12C
		// (set) Token: 0x06002F7C RID: 12156 RVA: 0x0001B388 File Offset: 0x00019588
		public unsafe float LifeSpan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_LifeSpan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_LifeSpan)) = value;
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x0013CF54 File Offset: 0x0013B154
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x0001B3A3 File Offset: 0x000195A3
		public unsafe bool AudioPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_AudioPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconOverride.NativeFieldInfoPtr_AudioPlayed)) = value;
			}
		}

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeFieldInfoPtr_GuestGroupController;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeFieldInfoPtr_IconInstances;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeFieldInfoPtr_GuestState;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeFieldInfoPtr_LifeSpan;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeFieldInfoPtr_AudioPlayed;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuestGroupController_Il2CppReferenceArray_1_GameObject_GuestState_Single_0;
	}
}
