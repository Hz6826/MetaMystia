using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020001A5 RID: 421
	public sealed class GuestIcon : ValueType
	{
		// Token: 0x06002F68 RID: 12136 RVA: 0x0013CC88 File Offset: 0x0013AE88
		// Note: this type is marked as 'beforefieldinit'.
		static GuestIcon()
		{
			Il2CppClassPointerStore<GuestIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.GuestManagementUtility", "GuestIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestIcon>.NativeClassPtr);
			GuestIcon.NativeFieldInfoPtr_GuestGroupController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIcon>.NativeClassPtr, "GuestGroupController");
			GuestIcon.NativeFieldInfoPtr_IconInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIcon>.NativeClassPtr, "IconInstances");
			GuestIcon.NativeFieldInfoPtr_GuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIcon>.NativeClassPtr, "GuestState");
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x0001B2A0 File Offset: 0x000194A0
		public GuestIcon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x0001B2A9 File Offset: 0x000194A9
		public GuestIcon() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestIcon>.NativeClassPtr))
		{
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x0013CCF4 File Offset: 0x0013AEF4
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x0001B2BB File Offset: 0x000194BB
		public unsafe GuestGroupController GuestGroupController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIcon.NativeFieldInfoPtr_GuestGroupController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIcon.NativeFieldInfoPtr_GuestGroupController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x0013CD24 File Offset: 0x0013AF24
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x0001B2DA File Offset: 0x000194DA
		public unsafe Il2CppReferenceArray<GameObject> IconInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIcon.NativeFieldInfoPtr_IconInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIcon.NativeFieldInfoPtr_IconInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x0013CD54 File Offset: 0x0013AF54
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x0001B2F9 File Offset: 0x000194F9
		public unsafe GuestState GuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIcon.NativeFieldInfoPtr_GuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIcon.NativeFieldInfoPtr_GuestState)) = value;
			}
		}

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeFieldInfoPtr_GuestGroupController;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeFieldInfoPtr_IconInstances;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeFieldInfoPtr_GuestState;
	}
}
