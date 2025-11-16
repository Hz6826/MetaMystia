using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000389 RID: 905
	public class NoteAnimationControllerAdvanced : NoteAnimationControllerBase
	{
		// Token: 0x06006BFB RID: 27643 RVA: 0x00206AFC File Offset: 0x00204CFC
		// Note: this type is marked as 'beforefieldinit'.
		static NoteAnimationControllerAdvanced()
		{
			Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "NoteAnimationControllerAdvanced");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr);
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_SharedGoodOutlineColorHEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "s_SharedGoodOutlineColorHEX");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_SharedPerfectOutlineColorHEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "s_SharedPerfectOutlineColorHEX");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorHEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "s_PerfectColorHEX");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorInlineHEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "s_PerfectColorInlineHEX");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorLeftHEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "s_PerfectColorLeftHEX");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorInlineLeftHEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "s_PerfectColorInlineLeftHEX");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorRightHEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "s_PerfectColorRightHEX");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorInlineRightHEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "s_PerfectColorInlineRightHEX");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_CatchColorHEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "s_CatchColorHEX");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_SHARED_GOOD_OUTLINE_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "SHARED_GOOD_OUTLINE_COLOR");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_SHARED_PERFECT_OUTLINE_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "SHARED_PERFECT_OUTLINE_COLOR");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "PERFECT_COLOR");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_INLINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "PERFECT_COLOR_INLINE");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "PERFECT_COLOR_LEFT");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_INLINE_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "PERFECT_COLOR_INLINE_LEFT");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "PERFECT_COLOR_RIGHT");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_INLINE_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "PERFECT_COLOR_INLINE_RIGHT");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_CATCH_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "CATCH_COLOR");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_NoteImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "NoteImage");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_OutlineImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "OutlineImage");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_InlineImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "InlineImage");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_DirectionIndicatorLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "DirectionIndicatorLeft");
			NoteAnimationControllerAdvanced.NativeFieldInfoPtr_DirectionIndicatorRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "DirectionIndicatorRight");
			NoteAnimationControllerAdvanced.NativeMethodInfoPtr_GetColor_Private_Color32_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, 100685567);
			NoteAnimationControllerAdvanced.NativeMethodInfoPtr_OnNoteChangeToGood_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, 100685568);
			NoteAnimationControllerAdvanced.NativeMethodInfoPtr_OnNoteChangeToMiss_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, 100685569);
			NoteAnimationControllerAdvanced.NativeMethodInfoPtr_OnNoteChangeToPerfect_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, 100685570);
			NoteAnimationControllerAdvanced.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, 100685571);
			NoteAnimationControllerAdvanced.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, 100685572);
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x00206D70 File Offset: 0x00204F70
		[CallerCount(0)]
		public unsafe Color32 GetColor(Color32 bothSideColor, Color32 leftColor, Color32 rightColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bothSideColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.NativeMethodInfoPtr_GetColor_Private_Color32_Color32_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x00206DD8 File Offset: 0x00204FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273307, XrefRangeEnd = 273326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnNoteChangeToGood()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteAnimationControllerAdvanced.NativeMethodInfoPtr_OnNoteChangeToGood_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x00206E14 File Offset: 0x00205014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273326, XrefRangeEnd = 273388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnNoteChangeToMiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteAnimationControllerAdvanced.NativeMethodInfoPtr_OnNoteChangeToMiss_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x00206E50 File Offset: 0x00205050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273388, XrefRangeEnd = 273508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnNoteChangeToPerfect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteAnimationControllerAdvanced.NativeMethodInfoPtr_OnNoteChangeToPerfect_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x00206E8C File Offset: 0x0020508C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273508, XrefRangeEnd = 273513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteAnimationControllerAdvanced.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x00206EC8 File Offset: 0x002050C8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteAnimationControllerAdvanced() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x0003A79E File Offset: 0x0003899E
		public NoteAnimationControllerAdvanced(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x06006C03 RID: 27651 RVA: 0x00206F04 File Offset: 0x00205104
		// (set) Token: 0x06006C04 RID: 27652 RVA: 0x0003A7A7 File Offset: 0x000389A7
		public unsafe static string s_SharedGoodOutlineColorHEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_SharedGoodOutlineColorHEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_SharedGoodOutlineColorHEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x06006C05 RID: 27653 RVA: 0x00206F24 File Offset: 0x00205124
		// (set) Token: 0x06006C06 RID: 27654 RVA: 0x0003A7B9 File Offset: 0x000389B9
		public unsafe static string s_SharedPerfectOutlineColorHEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_SharedPerfectOutlineColorHEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_SharedPerfectOutlineColorHEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x06006C07 RID: 27655 RVA: 0x00206F44 File Offset: 0x00205144
		// (set) Token: 0x06006C08 RID: 27656 RVA: 0x0003A7CB File Offset: 0x000389CB
		public unsafe static string s_PerfectColorHEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorHEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorHEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x06006C09 RID: 27657 RVA: 0x00206F64 File Offset: 0x00205164
		// (set) Token: 0x06006C0A RID: 27658 RVA: 0x0003A7DD File Offset: 0x000389DD
		public unsafe static string s_PerfectColorInlineHEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorInlineHEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorInlineHEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x06006C0B RID: 27659 RVA: 0x00206F84 File Offset: 0x00205184
		// (set) Token: 0x06006C0C RID: 27660 RVA: 0x0003A7EF File Offset: 0x000389EF
		public unsafe static string s_PerfectColorLeftHEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorLeftHEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorLeftHEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x06006C0D RID: 27661 RVA: 0x00206FA4 File Offset: 0x002051A4
		// (set) Token: 0x06006C0E RID: 27662 RVA: 0x0003A801 File Offset: 0x00038A01
		public unsafe static string s_PerfectColorInlineLeftHEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorInlineLeftHEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorInlineLeftHEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x06006C0F RID: 27663 RVA: 0x00206FC4 File Offset: 0x002051C4
		// (set) Token: 0x06006C10 RID: 27664 RVA: 0x0003A813 File Offset: 0x00038A13
		public unsafe static string s_PerfectColorRightHEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorRightHEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorRightHEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x06006C11 RID: 27665 RVA: 0x00206FE4 File Offset: 0x002051E4
		// (set) Token: 0x06006C12 RID: 27666 RVA: 0x0003A825 File Offset: 0x00038A25
		public unsafe static string s_PerfectColorInlineRightHEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorInlineRightHEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_PerfectColorInlineRightHEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x06006C13 RID: 27667 RVA: 0x00207004 File Offset: 0x00205204
		// (set) Token: 0x06006C14 RID: 27668 RVA: 0x0003A837 File Offset: 0x00038A37
		public unsafe static string s_CatchColorHEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_CatchColorHEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_s_CatchColorHEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x06006C15 RID: 27669 RVA: 0x00207024 File Offset: 0x00205224
		// (set) Token: 0x06006C16 RID: 27670 RVA: 0x0003A849 File Offset: 0x00038A49
		public unsafe static Color32 SHARED_GOOD_OUTLINE_COLOR
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_SHARED_GOOD_OUTLINE_COLOR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_SHARED_GOOD_OUTLINE_COLOR, (void*)(&value));
			}
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x06006C17 RID: 27671 RVA: 0x00207040 File Offset: 0x00205240
		// (set) Token: 0x06006C18 RID: 27672 RVA: 0x0003A857 File Offset: 0x00038A57
		public unsafe static Color32 SHARED_PERFECT_OUTLINE_COLOR
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_SHARED_PERFECT_OUTLINE_COLOR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_SHARED_PERFECT_OUTLINE_COLOR, (void*)(&value));
			}
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x06006C19 RID: 27673 RVA: 0x0020705C File Offset: 0x0020525C
		// (set) Token: 0x06006C1A RID: 27674 RVA: 0x0003A865 File Offset: 0x00038A65
		public unsafe static Color32 PERFECT_COLOR
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR, (void*)(&value));
			}
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x06006C1B RID: 27675 RVA: 0x00207078 File Offset: 0x00205278
		// (set) Token: 0x06006C1C RID: 27676 RVA: 0x0003A873 File Offset: 0x00038A73
		public unsafe static Color32 PERFECT_COLOR_INLINE
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_INLINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_INLINE, (void*)(&value));
			}
		}

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x06006C1D RID: 27677 RVA: 0x00207094 File Offset: 0x00205294
		// (set) Token: 0x06006C1E RID: 27678 RVA: 0x0003A881 File Offset: 0x00038A81
		public unsafe static Color32 PERFECT_COLOR_LEFT
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_LEFT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_LEFT, (void*)(&value));
			}
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x002070B0 File Offset: 0x002052B0
		// (set) Token: 0x06006C20 RID: 27680 RVA: 0x0003A88F File Offset: 0x00038A8F
		public unsafe static Color32 PERFECT_COLOR_INLINE_LEFT
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_INLINE_LEFT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_INLINE_LEFT, (void*)(&value));
			}
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x002070CC File Offset: 0x002052CC
		// (set) Token: 0x06006C22 RID: 27682 RVA: 0x0003A89D File Offset: 0x00038A9D
		public unsafe static Color32 PERFECT_COLOR_RIGHT
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_RIGHT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_RIGHT, (void*)(&value));
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x06006C23 RID: 27683 RVA: 0x002070E8 File Offset: 0x002052E8
		// (set) Token: 0x06006C24 RID: 27684 RVA: 0x0003A8AB File Offset: 0x00038AAB
		public unsafe static Color32 PERFECT_COLOR_INLINE_RIGHT
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_INLINE_RIGHT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_PERFECT_COLOR_INLINE_RIGHT, (void*)(&value));
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x06006C25 RID: 27685 RVA: 0x00207104 File Offset: 0x00205304
		// (set) Token: 0x06006C26 RID: 27686 RVA: 0x0003A8B9 File Offset: 0x00038AB9
		public unsafe static Color32 CATCH_COLOR
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_CATCH_COLOR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_CATCH_COLOR, (void*)(&value));
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x06006C27 RID: 27687 RVA: 0x00207120 File Offset: 0x00205320
		// (set) Token: 0x06006C28 RID: 27688 RVA: 0x0003A8C7 File Offset: 0x00038AC7
		public unsafe Il2CppReferenceArray<Image> NoteImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_NoteImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_NoteImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x06006C29 RID: 27689 RVA: 0x00207150 File Offset: 0x00205350
		// (set) Token: 0x06006C2A RID: 27690 RVA: 0x0003A8E6 File Offset: 0x00038AE6
		public unsafe Il2CppReferenceArray<Image> OutlineImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_OutlineImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_OutlineImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x06006C2B RID: 27691 RVA: 0x00207180 File Offset: 0x00205380
		// (set) Token: 0x06006C2C RID: 27692 RVA: 0x0003A905 File Offset: 0x00038B05
		public unsafe Il2CppReferenceArray<Image> InlineImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_InlineImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_InlineImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x06006C2D RID: 27693 RVA: 0x002071B0 File Offset: 0x002053B0
		// (set) Token: 0x06006C2E RID: 27694 RVA: 0x0003A924 File Offset: 0x00038B24
		public unsafe Image DirectionIndicatorLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_DirectionIndicatorLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_DirectionIndicatorLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x06006C2F RID: 27695 RVA: 0x002071E0 File Offset: 0x002053E0
		// (set) Token: 0x06006C30 RID: 27696 RVA: 0x0003A943 File Offset: 0x00038B43
		public unsafe Image DirectionIndicatorRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_DirectionIndicatorRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.NativeFieldInfoPtr_DirectionIndicatorRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004796 RID: 18326
		private static readonly IntPtr NativeFieldInfoPtr_s_SharedGoodOutlineColorHEX;

		// Token: 0x04004797 RID: 18327
		private static readonly IntPtr NativeFieldInfoPtr_s_SharedPerfectOutlineColorHEX;

		// Token: 0x04004798 RID: 18328
		private static readonly IntPtr NativeFieldInfoPtr_s_PerfectColorHEX;

		// Token: 0x04004799 RID: 18329
		private static readonly IntPtr NativeFieldInfoPtr_s_PerfectColorInlineHEX;

		// Token: 0x0400479A RID: 18330
		private static readonly IntPtr NativeFieldInfoPtr_s_PerfectColorLeftHEX;

		// Token: 0x0400479B RID: 18331
		private static readonly IntPtr NativeFieldInfoPtr_s_PerfectColorInlineLeftHEX;

		// Token: 0x0400479C RID: 18332
		private static readonly IntPtr NativeFieldInfoPtr_s_PerfectColorRightHEX;

		// Token: 0x0400479D RID: 18333
		private static readonly IntPtr NativeFieldInfoPtr_s_PerfectColorInlineRightHEX;

		// Token: 0x0400479E RID: 18334
		private static readonly IntPtr NativeFieldInfoPtr_s_CatchColorHEX;

		// Token: 0x0400479F RID: 18335
		private static readonly IntPtr NativeFieldInfoPtr_SHARED_GOOD_OUTLINE_COLOR;

		// Token: 0x040047A0 RID: 18336
		private static readonly IntPtr NativeFieldInfoPtr_SHARED_PERFECT_OUTLINE_COLOR;

		// Token: 0x040047A1 RID: 18337
		private static readonly IntPtr NativeFieldInfoPtr_PERFECT_COLOR;

		// Token: 0x040047A2 RID: 18338
		private static readonly IntPtr NativeFieldInfoPtr_PERFECT_COLOR_INLINE;

		// Token: 0x040047A3 RID: 18339
		private static readonly IntPtr NativeFieldInfoPtr_PERFECT_COLOR_LEFT;

		// Token: 0x040047A4 RID: 18340
		private static readonly IntPtr NativeFieldInfoPtr_PERFECT_COLOR_INLINE_LEFT;

		// Token: 0x040047A5 RID: 18341
		private static readonly IntPtr NativeFieldInfoPtr_PERFECT_COLOR_RIGHT;

		// Token: 0x040047A6 RID: 18342
		private static readonly IntPtr NativeFieldInfoPtr_PERFECT_COLOR_INLINE_RIGHT;

		// Token: 0x040047A7 RID: 18343
		private static readonly IntPtr NativeFieldInfoPtr_CATCH_COLOR;

		// Token: 0x040047A8 RID: 18344
		private static readonly IntPtr NativeFieldInfoPtr_NoteImage;

		// Token: 0x040047A9 RID: 18345
		private static readonly IntPtr NativeFieldInfoPtr_OutlineImage;

		// Token: 0x040047AA RID: 18346
		private static readonly IntPtr NativeFieldInfoPtr_InlineImage;

		// Token: 0x040047AB RID: 18347
		private static readonly IntPtr NativeFieldInfoPtr_DirectionIndicatorLeft;

		// Token: 0x040047AC RID: 18348
		private static readonly IntPtr NativeFieldInfoPtr_DirectionIndicatorRight;

		// Token: 0x040047AD RID: 18349
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Private_Color32_Color32_Color32_Color32_0;

		// Token: 0x040047AE RID: 18350
		private static readonly IntPtr NativeMethodInfoPtr_OnNoteChangeToGood_Public_Virtual_Void_0;

		// Token: 0x040047AF RID: 18351
		private static readonly IntPtr NativeMethodInfoPtr_OnNoteChangeToMiss_Public_Virtual_Void_0;

		// Token: 0x040047B0 RID: 18352
		private static readonly IntPtr NativeMethodInfoPtr_OnNoteChangeToPerfect_Public_Virtual_Void_0;

		// Token: 0x040047B1 RID: 18353
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040047B2 RID: 18354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000EB3 RID: 3763
		[ObfuscatedName("Common.UI.QTEUtility.NoteAnimationControllerAdvanced+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060109C7 RID: 68039 RVA: 0x003D8FA4 File Offset: 0x003D71A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr);
				NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, "<>9");
				NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, "<>9__24_0");
				NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, "<>9__25_0");
				NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, "<>9__25_1");
				NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, "<>9__26_0");
				NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, 100685575);
				NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__OnNoteChangeToGood_b__24_0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, 100685576);
				NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__OnNoteChangeToMiss_b__25_0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, 100685577);
				NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__OnNoteChangeToMiss_b__25_1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, 100685578);
				NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__OnNoteChangeToPerfect_b__26_0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr, 100685579);
			}

			// Token: 0x060109C8 RID: 68040 RVA: 0x003D9098 File Offset: 0x003D7298
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109C9 RID: 68041 RVA: 0x003D90D4 File Offset: 0x003D72D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273297, XrefRangeEnd = 273302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNoteChangeToGood_b__24_0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__OnNoteChangeToGood_b__24_0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109CA RID: 68042 RVA: 0x003D9118 File Offset: 0x003D7318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNoteChangeToMiss_b__25_0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__OnNoteChangeToMiss_b__25_0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109CB RID: 68043 RVA: 0x003D915C File Offset: 0x003D735C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNoteChangeToMiss_b__25_1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__OnNoteChangeToMiss_b__25_1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109CC RID: 68044 RVA: 0x003D91A0 File Offset: 0x003D73A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273302, XrefRangeEnd = 273306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNoteChangeToPerfect_b__26_0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.__c.NativeMethodInfoPtr__OnNoteChangeToPerfect_b__26_0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109CD RID: 68045 RVA: 0x00090F00 File Offset: 0x0008F100
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056A2 RID: 22178
			// (get) Token: 0x060109CE RID: 68046 RVA: 0x003D91E4 File Offset: 0x003D73E4
			// (set) Token: 0x060109CF RID: 68047 RVA: 0x00090F09 File Offset: 0x0008F109
			public unsafe static NoteAnimationControllerAdvanced.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteAnimationControllerAdvanced.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056A3 RID: 22179
			// (get) Token: 0x060109D0 RID: 68048 RVA: 0x003D920C File Offset: 0x003D740C
			// (set) Token: 0x060109D1 RID: 68049 RVA: 0x00090F1B File Offset: 0x0008F11B
			public unsafe static Action<Image> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056A4 RID: 22180
			// (get) Token: 0x060109D2 RID: 68050 RVA: 0x003D9234 File Offset: 0x003D7434
			// (set) Token: 0x060109D3 RID: 68051 RVA: 0x00090F2D File Offset: 0x0008F12D
			public unsafe static Action<Image> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056A5 RID: 22181
			// (get) Token: 0x060109D4 RID: 68052 RVA: 0x003D925C File Offset: 0x003D745C
			// (set) Token: 0x060109D5 RID: 68053 RVA: 0x00090F3F File Offset: 0x0008F13F
			public unsafe static Action<Image> __9__25_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__25_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056A6 RID: 22182
			// (get) Token: 0x060109D6 RID: 68054 RVA: 0x003D9284 File Offset: 0x003D7484
			// (set) Token: 0x060109D7 RID: 68055 RVA: 0x00090F51 File Offset: 0x0008F151
			public unsafe static Action<Image> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteAnimationControllerAdvanced.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A817 RID: 43031
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A818 RID: 43032
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400A819 RID: 43033
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x0400A81A RID: 43034
			private static readonly IntPtr NativeFieldInfoPtr___9__25_1;

			// Token: 0x0400A81B RID: 43035
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x0400A81C RID: 43036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A81D RID: 43037
			private static readonly IntPtr NativeMethodInfoPtr__OnNoteChangeToGood_b__24_0_Internal_Void_Image_0;

			// Token: 0x0400A81E RID: 43038
			private static readonly IntPtr NativeMethodInfoPtr__OnNoteChangeToMiss_b__25_0_Internal_Void_Image_0;

			// Token: 0x0400A81F RID: 43039
			private static readonly IntPtr NativeMethodInfoPtr__OnNoteChangeToMiss_b__25_1_Internal_Void_Image_0;

			// Token: 0x0400A820 RID: 43040
			private static readonly IntPtr NativeMethodInfoPtr__OnNoteChangeToPerfect_b__26_0_Internal_Void_Image_0;
		}

		// Token: 0x02000EB4 RID: 3764
		[ObfuscatedName("Common.UI.QTEUtility.NoteAnimationControllerAdvanced+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x060109D8 RID: 68056 RVA: 0x003D92AC File Offset: 0x003D74AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass25_0>.NativeClassPtr);
				NoteAnimationControllerAdvanced.__c__DisplayClass25_0.NativeFieldInfoPtr_perfectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass25_0>.NativeClassPtr, "perfectColor");
				NoteAnimationControllerAdvanced.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass25_0>.NativeClassPtr, 100685580);
				NoteAnimationControllerAdvanced.__c__DisplayClass25_0.NativeMethodInfoPtr__OnNoteChangeToMiss_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass25_0>.NativeClassPtr, 100685581);
			}

			// Token: 0x060109D9 RID: 68057 RVA: 0x003D9314 File Offset: 0x003D7514
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109DA RID: 68058 RVA: 0x003D9350 File Offset: 0x003D7550
			[CallerCount(0)]
			public unsafe void _OnNoteChangeToMiss_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.__c__DisplayClass25_0.NativeMethodInfoPtr__OnNoteChangeToMiss_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109DB RID: 68059 RVA: 0x00090F63 File Offset: 0x0008F163
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056A7 RID: 22183
			// (get) Token: 0x060109DC RID: 68060 RVA: 0x003D9394 File Offset: 0x003D7594
			// (set) Token: 0x060109DD RID: 68061 RVA: 0x00090F6C File Offset: 0x0008F16C
			public unsafe Color32 perfectColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.__c__DisplayClass25_0.NativeFieldInfoPtr_perfectColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.__c__DisplayClass25_0.NativeFieldInfoPtr_perfectColor)) = value;
				}
			}

			// Token: 0x0400A821 RID: 43041
			private static readonly IntPtr NativeFieldInfoPtr_perfectColor;

			// Token: 0x0400A822 RID: 43042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A823 RID: 43043
			private static readonly IntPtr NativeMethodInfoPtr__OnNoteChangeToMiss_b__2_Internal_Void_Image_0;
		}

		// Token: 0x02000EB5 RID: 3765
		[ObfuscatedName("Common.UI.QTEUtility.NoteAnimationControllerAdvanced+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x060109DE RID: 68062 RVA: 0x003D93BC File Offset: 0x003D75BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteAnimationControllerAdvanced>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass26_0>.NativeClassPtr);
				NoteAnimationControllerAdvanced.__c__DisplayClass26_0.NativeFieldInfoPtr_perfectInlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass26_0>.NativeClassPtr, "perfectInlineColor");
				NoteAnimationControllerAdvanced.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass26_0>.NativeClassPtr, 100685582);
				NoteAnimationControllerAdvanced.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNoteChangeToPerfect_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass26_0>.NativeClassPtr, 100685583);
			}

			// Token: 0x060109DF RID: 68063 RVA: 0x003D9424 File Offset: 0x003D7624
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteAnimationControllerAdvanced.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109E0 RID: 68064 RVA: 0x003D9460 File Offset: 0x003D7660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273306, XrefRangeEnd = 273307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNoteChangeToPerfect_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteAnimationControllerAdvanced.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNoteChangeToPerfect_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109E1 RID: 68065 RVA: 0x00090F87 File Offset: 0x0008F187
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056A8 RID: 22184
			// (get) Token: 0x060109E2 RID: 68066 RVA: 0x003D94A4 File Offset: 0x003D76A4
			// (set) Token: 0x060109E3 RID: 68067 RVA: 0x00090F90 File Offset: 0x0008F190
			public unsafe Color32 perfectInlineColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.__c__DisplayClass26_0.NativeFieldInfoPtr_perfectInlineColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteAnimationControllerAdvanced.__c__DisplayClass26_0.NativeFieldInfoPtr_perfectInlineColor)) = value;
				}
			}

			// Token: 0x0400A824 RID: 43044
			private static readonly IntPtr NativeFieldInfoPtr_perfectInlineColor;

			// Token: 0x0400A825 RID: 43045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A826 RID: 43046
			private static readonly IntPtr NativeMethodInfoPtr__OnNoteChangeToPerfect_b__1_Internal_Void_Image_0;
		}
	}
}
