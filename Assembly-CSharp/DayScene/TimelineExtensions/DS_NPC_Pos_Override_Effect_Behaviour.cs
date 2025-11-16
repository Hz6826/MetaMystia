using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000142 RID: 322
	public class DS_NPC_Pos_Override_Effect_Behaviour : DS_NPC_Pos_Effect_Behaviour
	{
		// Token: 0x06002658 RID: 9816 RVA: 0x0011F010 File Offset: 0x0011D210
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Pos_Override_Effect_Behaviour()
		{
			Il2CppClassPointerStore<DS_NPC_Pos_Override_Effect_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Pos_Override_Effect_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_Override_Effect_Behaviour>.NativeClassPtr);
			DS_NPC_Pos_Override_Effect_Behaviour.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override_Effect_Behaviour>.NativeClassPtr, "mapLabel");
			DS_NPC_Pos_Override_Effect_Behaviour.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override_Effect_Behaviour>.NativeClassPtr, "position");
			DS_NPC_Pos_Override_Effect_Behaviour.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override_Effect_Behaviour>.NativeClassPtr, "rotation");
			DS_NPC_Pos_Override_Effect_Behaviour.NativeMethodInfoPtr_TryGetCharacterPosition_Protected_Virtual_Boolean_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Override_Effect_Behaviour>.NativeClassPtr, 100670185);
			DS_NPC_Pos_Override_Effect_Behaviour.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Override_Effect_Behaviour>.NativeClassPtr, 100670186);
			DS_NPC_Pos_Override_Effect_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Override_Effect_Behaviour>.NativeClassPtr, 100670187);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x0011F0B8 File Offset: 0x0011D2B8
		[CallerCount(0)]
		public unsafe override bool TryGetCharacterPosition(out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Override_Effect_Behaviour.NativeMethodInfoPtr_TryGetCharacterPosition_Protected_Virtual_Boolean_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x0011F10C File Offset: 0x0011D30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90214, XrefRangeEnd = 90216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(string characterLabel, bool timeContinue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeContinue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Override_Effect_Behaviour.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x0011F168 File Offset: 0x0011D368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Pos_Override_Effect_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_Override_Effect_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Override_Effect_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00016A0D File Offset: 0x00014C0D
		public DS_NPC_Pos_Override_Effect_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x0011F1A4 File Offset: 0x0011D3A4
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x00016A16 File Offset: 0x00014C16
		public unsafe string mapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Effect_Behaviour.NativeFieldInfoPtr_mapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Effect_Behaviour.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x0011F1CC File Offset: 0x0011D3CC
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x00016A35 File Offset: 0x00014C35
		public unsafe Vector2 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Effect_Behaviour.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Effect_Behaviour.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x0011F1F4 File Offset: 0x0011D3F4
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x00016A50 File Offset: 0x00014C50
		public unsafe int rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Effect_Behaviour.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Effect_Behaviour.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCharacterPosition_Protected_Virtual_Boolean_byref_Vector2_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_String_Boolean_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
